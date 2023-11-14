using System;
using System.Collections.Generic;
using com.system.payment.Domain.Systems;
using com.system.payment.Infrastructure.Factories.Presentation.Buttons;
using com.system.payment.Infrastructure.Providers;
using com.system.payment.Presentation.Buttons;
using com.system.payment.PresentationInterfaces.Forms;

namespace com.system.payment.Controllers.Payments
{
    public class PaymentSystemSelectorPresenter
    {
        private readonly IPaymentSystemSelectorView _paymentSystemSelectorView;
        private readonly PaymentSystemSelectorProvider _paymentSystemSelectorProvider;
        private readonly PaymentSystemButtonFactory _paymentSystemButtonFactory;
        private readonly IEnumerable<string> _paymentSystemNames;
        private readonly List<PaymentSystemInfo> _paymentSystemInfos = new List<PaymentSystemInfo>();

        public PaymentSystemSelectorPresenter(
            IPaymentSystemSelectorView paymentSystemSelectorView,
            PaymentSystemSelectorProvider paymentSystemSelectorProvider,
            PaymentSystemButtonFactory paymentSystemButtonFactory,
            IEnumerable<string> paymentSystemInfos
        )
        {
            _paymentSystemSelectorView = paymentSystemSelectorView ??
                                         throw new ArgumentNullException(nameof(paymentSystemSelectorView));
            
            _paymentSystemSelectorProvider = paymentSystemSelectorProvider ??
                                             throw new ArgumentNullException(nameof(paymentSystemSelectorProvider));

            _paymentSystemButtonFactory = paymentSystemButtonFactory ??
                                          throw new ArgumentNullException(nameof(paymentSystemButtonFactory));

            _paymentSystemNames = paymentSystemInfos ?? throw new ArgumentNullException(nameof(paymentSystemInfos));
        }

        public IEnumerable<PaymentSystemButton> CreateButtons()
        {
            foreach (string paymentSystemName in _paymentSystemNames)
            {
                PaymentSystemInfo info = new PaymentSystemInfo(paymentSystemName);
                _paymentSystemInfos.Add(info);

                yield return _paymentSystemButtonFactory.Create(info); // TODO: Move to factory
            }
        }

        public void Enable()
        {
            foreach (PaymentSystemInfo paymentSystemInfo in _paymentSystemInfos)
                paymentSystemInfo.Selected += OnInfoSelected;
        }

        public void Disable()
        {
            foreach (PaymentSystemInfo paymentSystemInfo in _paymentSystemInfos)
                paymentSystemInfo.Selected -= OnInfoSelected;
        }

        private void OnInfoSelected(PaymentSystemInfo info)
        {
            _paymentSystemSelectorProvider.PaymentSystemSelector = new PaymentSystemSelector(info.Name);
            _paymentSystemSelectorView.Disable();
        }
    }
}
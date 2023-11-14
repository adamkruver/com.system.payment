using System;
using System.Collections.Generic;
using System.Linq;
using com.system.payment.Domain.Systems;
using com.system.payment.Infrastructure.Factories.Presentation.Forms;
using com.system.payment.Infrastructure.Providers;
using com.system.payment.PresentationInterfaces.Forms;

namespace com.system.payment.Controllers.Payments
{
    public class PaymentPresenter
    {
        private readonly IPaymentView _paymentView;
        private readonly PaymentSystemSelectorProvider _paymentSystemSelectorProvider;
        private readonly PaymentSystemSelectorFormFactory _paymentSystemSelectorFormFactory;
        private readonly IEnumerable<IPaymentSystem> _paymentSystems;

        public PaymentPresenter(
            IPaymentView paymentView,
            PaymentSystemSelectorProvider paymentSystemSelectorProvider,
            PaymentSystemSelectorFormFactory paymentSystemSelectorFormFactory,
            IEnumerable<IPaymentSystem> paymentSystems
        )
        {
            _paymentView = paymentView ?? throw new ArgumentNullException(nameof(paymentView));
            
            _paymentSystemSelectorProvider = paymentSystemSelectorProvider ??
                                             throw new ArgumentNullException(nameof(paymentSystemSelectorProvider));

            _paymentSystemSelectorFormFactory = paymentSystemSelectorFormFactory ??
                                                throw new ArgumentNullException(
                                                    nameof(paymentSystemSelectorFormFactory)
                                                );
            _paymentSystems = paymentSystems;
        }

        public void SelectPaymentSystem() =>
            _paymentSystemSelectorFormFactory
                .Create(_paymentSystemSelectorProvider, _paymentSystems.Select(paymentSystem => paymentSystem.Name))
                .Enable();
    }
}
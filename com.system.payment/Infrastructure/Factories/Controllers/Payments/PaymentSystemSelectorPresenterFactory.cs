using System.Collections.Generic;
using com.system.payment.Controllers.Payments;
using com.system.payment.Domain.Systems;
using com.system.payment.Infrastructure.Factories.Presentation.Buttons;
using com.system.payment.Infrastructure.Providers;
using com.system.payment.PresentationInterfaces.Forms;

namespace com.system.payment.Infrastructure.Factories.Controllers.Payments
{
    public class PaymentSystemSelectorPresenterFactory
    {
        private readonly PaymentSystemButtonFactory _paymentSystemButtonFactory;

        public PaymentSystemSelectorPresenterFactory(PaymentSystemButtonFactory paymentSystemButtonFactory) =>
            _paymentSystemButtonFactory = paymentSystemButtonFactory;

        public PaymentSystemSelectorPresenter Create(
            IPaymentSystemSelectorView paymentSystemSelectorView,
            PaymentSystemSelectorProvider paymentSystemSelectorProvider,
            IEnumerable<string> paymentSystemNames
        ) =>
            new PaymentSystemSelectorPresenter(
                paymentSystemSelectorView, paymentSystemSelectorProvider, _paymentSystemButtonFactory, paymentSystemNames
            );
    }
}
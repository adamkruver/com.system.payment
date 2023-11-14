using System.Collections.Generic;
using com.system.payment.Controllers.Payments;
using com.system.payment.Domain.Systems;
using com.system.payment.Infrastructure.Factories.Presentation.Forms;
using com.system.payment.Infrastructure.Providers;
using com.system.payment.PresentationInterfaces.Forms;

namespace com.system.payment.Infrastructure.Factories.Controllers.Payments
{
    public class PaymentPresenterFactory
    {
        private readonly PaymentSystemSelectorFormFactory _paymentSystemSelectorFormFactory;

        public PaymentPresenterFactory(PaymentSystemSelectorFormFactory paymentSystemSelectorFormFactory) =>
            _paymentSystemSelectorFormFactory = paymentSystemSelectorFormFactory;

        public PaymentPresenter Create(
            IPaymentView paymentView,
            IEnumerable<IPaymentSystem> paymentSystems,
            PaymentSystemSelectorProvider paymentSystemSelectorProvider
        ) =>
            new PaymentPresenter(
                paymentView, paymentSystemSelectorProvider, _paymentSystemSelectorFormFactory, paymentSystems
            );
    }
}
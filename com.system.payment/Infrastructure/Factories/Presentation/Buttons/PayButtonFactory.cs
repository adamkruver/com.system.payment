using com.system.payment.Infrastructure.Factories.Controllers.Buttons;
using com.system.payment.InfrastructureInterfaces.Providers;
using com.system.payment.Presentation.Buttons;

namespace com.system.payment.Infrastructure.Factories.Presentation.Buttons
{
    public class PayButtonFactory
    {
        private readonly PayButtonPresenterFactory _payButtonPresenterFactory;
        private readonly IPaymentSystemSelectorProvider _paymentSystemSelectorProvider;

        public PayButtonFactory(
            PayButtonPresenterFactory payButtonPresenterFactory,
            IPaymentSystemSelectorProvider paymentSystemSelectorProvider
        )
        {
            _payButtonPresenterFactory = payButtonPresenterFactory;
            _paymentSystemSelectorProvider = paymentSystemSelectorProvider;
        }

        public PayButton Create()
        {
            PayButton payButton = new PayButton();
            payButton.Initialize(_payButtonPresenterFactory.Create(_paymentSystemSelectorProvider, payButton));

            return payButton;
        }
    }
}
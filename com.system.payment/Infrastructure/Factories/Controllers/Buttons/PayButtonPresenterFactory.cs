using com.system.payment.Controllers.Buttons;
using com.system.payment.InfrastructureInterfaces.Providers;
using com.system.payment.PresentationInterfaces.Buttons;

namespace com.system.payment.Infrastructure.Factories.Controllers.Buttons
{
    public class PayButtonPresenterFactory
    {
        public PayButtonPresenter Create(IPaymentSystemSelectorProvider paymentSystemSelectorProvider, IPayButton payButton) =>
            new PayButtonPresenter(paymentSystemSelectorProvider, payButton);
    }
}
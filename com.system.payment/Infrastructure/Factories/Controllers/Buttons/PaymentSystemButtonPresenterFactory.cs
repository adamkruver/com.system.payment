using com.system.payment.Controllers.Buttons;
using com.system.payment.Domain.Systems;
using com.system.payment.PresentationInterfaces.Buttons;

namespace com.system.payment.Infrastructure.Factories.Controllers.Buttons
{
    public class PaymentSystemButtonPresenterFactory
    {
        private readonly PaymentSystemInfo _paymentSystemInfo;

        public PaymentSystemButtonPresenterFactory(PaymentSystemInfo paymentSystemInfo) =>
            _paymentSystemInfo = paymentSystemInfo;

        public PaymentSystemButtonPresenter Create(IPaymentSystemButton paymentSystemButton) =>
            new PaymentSystemButtonPresenter(paymentSystemButton, _paymentSystemInfo);
    }
}
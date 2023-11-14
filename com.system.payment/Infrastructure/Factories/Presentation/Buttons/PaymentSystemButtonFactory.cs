using com.system.payment.Domain.Systems;
using com.system.payment.Infrastructure.Factories.Controllers.Buttons;
using com.system.payment.Presentation.Buttons;

namespace com.system.payment.Infrastructure.Factories.Presentation.Buttons
{
    public class PaymentSystemButtonFactory
    {
        public PaymentSystemButton Create(PaymentSystemInfo paymentSystemInfo) => 
            new PaymentSystemButton(new PaymentSystemButtonPresenterFactory(paymentSystemInfo));
    }
}
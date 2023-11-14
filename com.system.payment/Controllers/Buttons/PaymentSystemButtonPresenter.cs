using com.system.payment.Domain.Systems;
using com.system.payment.PresentationInterfaces.Buttons;

namespace com.system.payment.Controllers.Buttons
{
    public class PaymentSystemButtonPresenter
    {
        private readonly IPaymentSystemButton _button;
        private readonly PaymentSystemInfo _paymentSystemInfo;

        public PaymentSystemButtonPresenter(IPaymentSystemButton button, PaymentSystemInfo paymentSystemInfo)
        {
            _button = button;
            _paymentSystemInfo = paymentSystemInfo;

            Initialize();
        }

        public void Select() => 
            _paymentSystemInfo.Select();

        private void Initialize() => 
            _button.SetName(_paymentSystemInfo.Name);
    }
}
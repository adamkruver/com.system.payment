using com.system.payment.InfrastructureInterfaces.Providers;
using com.system.payment.PresentationInterfaces.Buttons;

namespace com.system.payment.Controllers.Buttons
{
    public class PayButtonPresenter
    {
        private readonly IPaymentSystemSelectorProvider _paymentSystemSelectorProvider;
        private readonly IPayButton _payButton;

        public PayButtonPresenter(IPaymentSystemSelectorProvider paymentSystemSelectorProvider, IPayButton payButton)
        {
            _paymentSystemSelectorProvider = paymentSystemSelectorProvider;
            _payButton = payButton;
        }

        public void Enable() =>
            _paymentSystemSelectorProvider.Changed += OnPaymentSystemSelectorChanged;

        public void Disable() =>
            _paymentSystemSelectorProvider.Changed -= OnPaymentSystemSelectorChanged;

        public void Pay() => 
            _payButton.Disable();

        private void OnPaymentSystemSelectorChanged()
        {
            _payButton.SetText($"Оплатить с помощью {_paymentSystemSelectorProvider.PaymentSystemSelector.Name}");
            _payButton.Enable();
        }
    }
}
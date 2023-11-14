using System;
using com.system.payment.Domain.Systems;
using com.system.payment.InfrastructureInterfaces.Providers;

namespace com.system.payment.Infrastructure.Providers
{
    public class PaymentSystemSelectorProvider : IPaymentSystemSelectorProvider
    {
        private PaymentSystemSelector _paymentSystemSelector;

        public event Action Changed;

        public PaymentSystemSelector PaymentSystemSelector
        {
            get => _paymentSystemSelector;
            set
            {
                _paymentSystemSelector = value;
                
                Changed?.Invoke();
            }
        }
    }
}
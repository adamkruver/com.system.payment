using System;

namespace com.system.payment.Domain.Systems
{
    public class PaymentSystemInfo
    {
        public PaymentSystemInfo(string name) =>
            Name = name;

        public event Action<PaymentSystemInfo> Selected; 
        
        public void Select() => 
            Selected?.Invoke(this);

        public string Name { get; }
    }
}
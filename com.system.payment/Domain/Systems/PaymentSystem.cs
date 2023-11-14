namespace com.system.payment.Domain.Systems
{
    public class PaymentSystem : IPaymentSystem
    {
        public PaymentSystem(string name) =>
            Name = name;

        public string Name { get; }
    }
}
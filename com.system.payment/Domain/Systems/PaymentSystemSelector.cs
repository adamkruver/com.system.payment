namespace com.system.payment.Domain.Systems
{
    public class PaymentSystemSelector
    {
        public PaymentSystemSelector(string name) =>
            Name = name;

        public string Name { get; }
    }
}
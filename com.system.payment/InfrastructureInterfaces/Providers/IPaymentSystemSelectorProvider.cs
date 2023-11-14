using System;
using com.system.payment.Domain.Systems;

namespace com.system.payment.InfrastructureInterfaces.Providers
{
    public interface IPaymentSystemSelectorProvider
    {
        event Action Changed;
        PaymentSystemSelector PaymentSystemSelector { get; }
    }
}
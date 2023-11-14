using com.system.payment.App;
using com.system.payment.Infrastructure.Factories.Controllers.Buttons;
using com.system.payment.Infrastructure.Factories.Controllers.Payments;
using com.system.payment.Infrastructure.Factories.Presentation.Buttons;
using com.system.payment.Infrastructure.Factories.Presentation.Forms;
using com.system.payment.Infrastructure.Providers;
using com.system.payment.InfrastructureInterfaces.Providers;

namespace com.system.payment.Infrastructure.Factories.App
{
    public class AppCoreFactory
    {
        public AppCore Create()
        {
            PaymentSystemSelectorProvider paymentSystemSelectorProvider = new PaymentSystemSelectorProvider();
            
            PaymentSystemButtonFactory paymentSystemButtonFactory =
                new PaymentSystemButtonFactory();

            PaymentSystemSelectorPresenterFactory paymentSystemSelectorPresenterFactory =
                new PaymentSystemSelectorPresenterFactory(paymentSystemButtonFactory);

            PaymentSystemSelectorFormFactory paymentSystemSelectorFormFactory =
                new PaymentSystemSelectorFormFactory(paymentSystemSelectorPresenterFactory);

            PaymentPresenterFactory paymentPresenterFactory =
                new PaymentPresenterFactory(paymentSystemSelectorFormFactory);

            PayButtonPresenterFactory payButtonPresenterFactory = new PayButtonPresenterFactory();
            PayButtonFactory payButtonFactory = new PayButtonFactory(payButtonPresenterFactory, paymentSystemSelectorProvider);

            PaymentFormFactory startFormFactory = new PaymentFormFactory(paymentPresenterFactory, payButtonFactory,paymentSystemSelectorProvider);

            return new AppCore(startFormFactory);
        }
    }
}
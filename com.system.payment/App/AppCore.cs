using System.Collections.Generic;
using System.Windows.Forms;
using com.system.payment.Domain.Systems;
using com.system.payment.Infrastructure.Factories.Presentation.Forms;
using com.system.payment.Presentation.Forms;

namespace com.system.payment.App
{
    public class AppCore
    {
        private readonly PaymentFormFactory _formFactory;

        public AppCore(PaymentFormFactory formFactory) =>
            _formFactory = formFactory;

        public void Run()
        {
            List<IPaymentSystem> paymentSystems = new List<IPaymentSystem>()
            {
                new PaymentSystem("WebMoney"),
                new PaymentSystem("Card"),
                new PaymentSystem("Qiwi"),
            };

            PaymentForm form = _formFactory.Create(paymentSystems);
            form.Enable();

            Application.Run(form);
        }
    }
}
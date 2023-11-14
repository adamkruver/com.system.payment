using System;
using System.Drawing;
using System.Windows.Forms;
using com.system.payment.Controllers.Buttons;
using com.system.payment.Infrastructure.Factories.Controllers.Buttons;
using com.system.payment.PresentationInterfaces.Buttons;

namespace com.system.payment.Presentation.Buttons
{
    public class PaymentSystemButton : Button, IPaymentSystemButton
    {
        private readonly PaymentSystemButtonPresenter _paymentSystemButtonPresenter;

        public PaymentSystemButton(PaymentSystemButtonPresenterFactory paymentSystemButtonPresenterFactory)
        {
            Initialize();
            
            _paymentSystemButtonPresenter = paymentSystemButtonPresenterFactory?.Create(this) ??
                                            throw new ArgumentNullException(
                                                nameof(paymentSystemButtonPresenterFactory)
                                            );
        }

        private void Initialize()
        {
            Location = new Point(13, 14);
            Margin = new Padding(4, 5, 4, 5);
            Name = "paymentSystemButton";
            Size = new Size(144, 144);
            TabIndex = 0;
            Text = "WebMoney";
            UseVisualStyleBackColor = true;
            Click += new EventHandler(OnPaymentSystemButtonClick);
        }

        private void OnPaymentSystemButtonClick(object sender, EventArgs e)
        {
            _paymentSystemButtonPresenter.Select();
        }

        public void SetName(string name)
        {
            Text = name;
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;
using com.system.payment.Controllers.Buttons;
using com.system.payment.PresentationInterfaces.Buttons;

namespace com.system.payment.Presentation.Buttons
{
    public class PayButton : Button, IPayButton
    {
        private PayButtonPresenter _payButtonPresenter;

        public PayButton() =>
            InitializeComponent();

        private void InitializeComponent()
        {
            Enabled = false;
            Location = new Point(12, 237);
            Size = new Size(360, 64);
            TabIndex = 1;
            Text = "Оплатить";
            UseVisualStyleBackColor = true;

            Click += new EventHandler(OnButtonClick);
        }

        private void OnButtonClick(object sender, EventArgs e) => 
            _payButtonPresenter.Pay();

        public void Initialize(PayButtonPresenter payButtonPresenter)
        {
            _payButtonPresenter = payButtonPresenter;
            _payButtonPresenter.Enable();
        }

        public void SetText(string text) =>
            Text = text;

        public void Enable() =>
            Enabled = true;

        public void Disable() =>
            Enabled = false;
    }
}
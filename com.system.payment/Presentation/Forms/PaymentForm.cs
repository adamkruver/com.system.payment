using System;
using System.Windows.Forms;
using com.system.payment.Controllers.Payments;
using com.system.payment.Infrastructure.Factories.Presentation.Buttons;
using com.system.payment.PresentationInterfaces.Forms;

namespace com.system.payment.Presentation.Forms
{
    public partial class PaymentForm : Form, IPaymentView
    {
        private PaymentPresenter _paymentPresenter;

        public PaymentForm(PayButtonFactory payButtonFactory)
        {
            InitializeComponent();
            Controls.Add(payButtonFactory.Create());
        }

        public void Initialize(PaymentPresenter paymentPresenter) =>
            _paymentPresenter = paymentPresenter;

        public void Enable()
        {
        }

        public void Disable()
        {
        }

        private void OnSelectPaymentSystemButtonClick(object sender, EventArgs e) =>
            _paymentPresenter.SelectPaymentSystem();
    }
}
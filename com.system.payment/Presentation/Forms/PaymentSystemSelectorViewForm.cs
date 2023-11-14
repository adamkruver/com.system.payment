using System.Drawing;
using System.Windows.Forms;
using com.system.payment.Controllers.Payments;
using com.system.payment.PresentationInterfaces.Forms;

namespace com.system.payment.Presentation.Forms
{
    public partial class PaymentSystemSelectorViewForm : Form, IPaymentSystemSelectorView
    {
        private PaymentSystemSelectorPresenter _paymentSystemSelectorPresenter;

        public PaymentSystemSelectorViewForm() => 
            InitializeComponent();

        public void Initialize(PaymentSystemSelectorPresenter presenter)
        {
            _paymentSystemSelectorPresenter = presenter;
            AddButtons();            
        }

        private void AddButtons()
        {
            int currentPosition = 5;
            int marginRight = 5; 
            
            foreach (var button in _paymentSystemSelectorPresenter.CreateButtons())
            {
                button.Location = new Point(currentPosition, button.Location.Y);
                Controls.Add(button);

                currentPosition += marginRight + button.Size.Width;
            }
        }

        public void Enable()
        {
            _paymentSystemSelectorPresenter.Enable();
            ShowDialog();
        }

        public void Disable()
        {
            Hide();
            _paymentSystemSelectorPresenter.Disable();
        }
    }
}
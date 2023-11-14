using System;
using System.Collections.Generic;
using com.system.payment.Domain.Systems;
using com.system.payment.Infrastructure.Factories.Controllers.Payments;
using com.system.payment.Infrastructure.Factories.Presentation.Buttons;
using com.system.payment.Infrastructure.Providers;
using com.system.payment.Presentation.Forms;

namespace com.system.payment.Infrastructure.Factories.Presentation.Forms
{
    public class PaymentFormFactory
    {
        private readonly PaymentPresenterFactory _paymentPresenterFactory;
        private readonly PayButtonFactory _payButtonFactory;
        private readonly PaymentSystemSelectorProvider _paymentSystemSelectorProvider;

        public PaymentFormFactory(
            PaymentPresenterFactory paymentPresenterFactory,
            PayButtonFactory payButtonFactory,
            PaymentSystemSelectorProvider paymentSystemSelectorProvider
        )
        {
            _paymentPresenterFactory = paymentPresenterFactory ??
                                       throw new ArgumentNullException(nameof(paymentPresenterFactory));
            _payButtonFactory = payButtonFactory ?? throw new ArgumentNullException(nameof(payButtonFactory));
            _paymentSystemSelectorProvider = paymentSystemSelectorProvider ??
                                             throw new ArgumentNullException(nameof(paymentSystemSelectorProvider));
        }

        public PaymentForm Create(IEnumerable<IPaymentSystem> paymentSystems)
        {
            PaymentForm form = new PaymentForm(_payButtonFactory);
            form.Initialize(_paymentPresenterFactory.Create(form, paymentSystems, _paymentSystemSelectorProvider));

            return form;
        }
    }
}
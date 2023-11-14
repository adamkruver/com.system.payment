using System;
using System.Collections.Generic;
using com.system.payment.Controllers.Payments;
using com.system.payment.Domain.Systems;
using com.system.payment.Infrastructure.Factories.Controllers.Payments;
using com.system.payment.Infrastructure.Providers;
using com.system.payment.Presentation.Forms;

namespace com.system.payment.Infrastructure.Factories.Presentation.Forms
{
    public class PaymentSystemSelectorFormFactory
    {
        private readonly PaymentSystemSelectorPresenterFactory _paymentSystemSelectorPresenterFactory;

        public PaymentSystemSelectorFormFactory(
            PaymentSystemSelectorPresenterFactory paymentSystemSelectorPresenterFactory
        ) =>
            _paymentSystemSelectorPresenterFactory = paymentSystemSelectorPresenterFactory ??
                                                     throw new ArgumentNullException(
                                                         nameof(paymentSystemSelectorPresenterFactory)
                                                     );

        public PaymentSystemSelectorViewForm Create(
            PaymentSystemSelectorProvider paymentSystemSelectorProvider,
            IEnumerable<string> paymentSystemNames
        )
        {
            PaymentSystemSelectorViewForm form = new PaymentSystemSelectorViewForm();

            PaymentSystemSelectorPresenter presenter = _paymentSystemSelectorPresenterFactory.Create(
                form, paymentSystemSelectorProvider, paymentSystemNames
            );

            form.Initialize(presenter);

            return form;
        }
    }
}
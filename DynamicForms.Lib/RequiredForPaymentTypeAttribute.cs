using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicForms.Lib
{
    public class RequiredForPaymentTypeAttribute : Attribute
    {
        public RequiredForPaymentTypeAttribute(PaymentTypeFlags paymentTypes)
        {
            this.PaymentTypes = paymentTypes;
        }

        public PaymentTypeFlags PaymentTypes { get; }
    }
}

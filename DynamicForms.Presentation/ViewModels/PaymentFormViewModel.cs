using DynamicForms.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicForms.Presentation.ViewModels
{
    public class PaymentFormViewModel
    {
        public PaymentFormViewModel()
        {
        }

        public PaymentType PaymentType { get; set; }

        [RequiredForPaymentType(PaymentTypeFlags.All)]
        public string BeneficiaryAccountNumber { get; set; }

        [RequiredForPaymentType(PaymentTypeFlags.BACS)]
        public string BeneficiarySortCode { get; set; }

        [RequiredForPaymentType(PaymentTypeFlags.SWIFT)]
        public string BeneficaryBIC { get; set; }
    }
}

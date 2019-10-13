using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicForms.Lib.Extensions
{
    public static class EnumExtensions
    {
        public static PaymentTypeFlags GetPaymentTypeFlags(this PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.BACS:
                    return PaymentTypeFlags.BACS;
                case PaymentType.SWIFT:
                    return PaymentTypeFlags.SWIFT;
                default:
                    throw new Exception("All payment types should be handled.");
            }
        }
    }
}

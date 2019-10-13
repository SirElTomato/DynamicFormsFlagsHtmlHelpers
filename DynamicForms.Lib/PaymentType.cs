using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicForms.Lib
{
    public enum PaymentType
    {
        BACS,

        SWIFT,
    }

    [Flags]
    public enum PaymentTypeFlags
    {
        BACS = 1,

        SWIFT = 2,

        All = BACS | SWIFT,
    }
}

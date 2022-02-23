using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;

namespace Valtion.Core.Utilities.ValidationHelpers.StringHelpers
{
    public static class StringNullHelpers
    {
        public static string ShouldNotBeNull(this string value)
        {
            if (value == null)
                StringNullReferenceException.Throw();

            return value;
        }
    }
}

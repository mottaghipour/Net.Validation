using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;

namespace Valtion.Core.Utilities.ValidationHelpers.StringHelpers
{
    public static class WhiteSpaceHelpers
    {
        /// <summary>
        /// String should not be white space helper
        /// </summary>
        /// <param name="value"></param>
        /// <param name="message"></param>
        /// <returns><see cref="string"/> <paramref name="value"/></returns>
        /// <exception cref="StringWhiteSpaceException"></exception>
        public static string ShouldBeNotWhiteSpace(this string value, string message = "String white space exception occurred;")
        {
            value.ShouldNotBeNull();
            if (value == " ")
                StringWhiteSpaceException.Throw(message);

            return value;
        }
    }
}

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
        /// Helper => String should be white space
        /// </summary>
        /// <param name="value"></param>
        /// <param name="message"></param>
        /// <returns><see cref="string"/> <paramref name="value"/></returns>
        /// <exception cref="StringIsNotWhiteSpaceException"></exception>
        public static string ShouldBeWhiteSpace(this string value, string message = "String white space exception occurred;")
        {
            if (value != " ")
                StringIsNotWhiteSpaceException.Throw(message);

            return value;
        }

        /// <summary>
        /// Helper => String should not be white space
        /// </summary>
        /// <param name="value"></param>
        /// <param name="message"></param>
        /// <returns><see cref="string"/> <paramref name="value"/></returns>
        /// <exception cref="StringWhiteSpaceException"></exception>
        public static string ShouldNotBeWhiteSpace(this string value, string message = "String white space exception occurred;")
        {
            if (value == " ")
                StringWhiteSpaceException.Throw(message);

            return value;
        }
    }
}

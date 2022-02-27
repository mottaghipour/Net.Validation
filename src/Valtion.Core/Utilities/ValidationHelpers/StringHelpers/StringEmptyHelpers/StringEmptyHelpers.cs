using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;

namespace Valtion.Core.Utilities.ValidationHelpers.StringHelpers
{
    public static class StringEmptyHelpers
    {
        /// <summary>
        /// Helper => String should be empty
        /// </summary>
        /// <param name="value"></param>
        /// <returns><see cref="string"/> <paramref name="value"/></returns>
        /// <exception cref="StringIsNotEmptyException"></exception>
        public static string ShouldBeEmpty(this string value, string message = "String is not empty exception occurred;")
        {
            if (value != "")
                StringIsNotEmptyException.Throw(message);

            return value;
        }

        /// <summary>
        /// Helper => String should not be empty
        /// </summary>
        /// <param name="value"></param>
        /// <returns><see cref="string"/> <paramref name="value"/></returns>
        /// <exception cref="StringEmptyException"></exception>
        public static string ShouldNotBeEmpty(this string value, string message = "String empty exception occurred;")
        {
            if (value == "")
                StringEmptyException.Throw(message);

            return value;
        }
    }
}

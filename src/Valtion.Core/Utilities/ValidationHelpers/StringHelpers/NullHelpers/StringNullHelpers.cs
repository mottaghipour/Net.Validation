using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;

namespace Valtion.Core.Utilities.ValidationHelpers.StringHelpers
{
    public static partial class StringValidationHelpers
    {
        /// <summary>
        /// Helper => String should be <see langword="null"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="message"></param>
        /// <returns><see cref="string"/> <paramref name="value"/></returns>
        /// <exception cref="StringFullReferenceException"></exception>
        public static string ShouldBeNull(this string value, string message = "String full reference exception occurred;")
        {
            if (value != null)
                StringFullReferenceException.Throw(message);

            return value;
        }

        /// <summary>
        /// Helper => String should not be <see langword="null"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="message"></param>
        /// <returns><see cref="string"/> <paramref name="value"/></returns>
        /// <exception cref="StringNullReferenceException"></exception>
        public static string ShouldNotBeNull(this string value, string message = "String null reference exception occurred;")
        {
            if (value == null)
                StringNullReferenceException.Throw(message);

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;
using Valtion.Core.Utilities.ValidationHelpers.StringHelpers;

namespace Valtion.Validators.StringValidators
{
    public static partial class StringValidators
    {
        /// <summary>
        /// String required validator
        /// </summary>
        /// <param name="value"></param>
        /// <param name="message"></param>
        /// <returns><see cref="string"/> <paramref name="value"/></returns>
        /// <exception cref="StringNullReferenceException"></exception>
        /// <exception cref="StringEmptyException"></exception>
        /// <exception cref="StringWhiteSpaceException"></exception>
        public static string Required(this string value, string message = "This field is required;")
        {
            return value
                .ShouldNotBeNull(message)
                .ShouldNotBeEmpty(message)
                .ShouldNotBeWhiteSpace(message);
        }
    }
}

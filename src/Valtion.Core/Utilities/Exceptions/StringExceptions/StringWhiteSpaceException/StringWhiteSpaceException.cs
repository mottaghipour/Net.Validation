using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtion.Core.Utilities.Exceptions.StringExceptions
{
    public class StringWhiteSpaceException : Exception
    {
        /// <summary>
        /// Contractor <see cref="StringWhiteSpaceException"/> without parameters
        /// </summary>
        public StringWhiteSpaceException() : base() { }

        /// <summary>
        /// Contractor <see cref="StringWhiteSpaceException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="message"></param>
        public StringWhiteSpaceException(string message) : base(message) { }

        /// <summary>
        /// Contractor <see cref="StringWhiteSpaceException"/> with <paramref name="message"/> and <paramref name="innerException"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public StringWhiteSpaceException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Throw <see cref="StringWhiteSpaceException"/> without parameters
        /// </summary>
        /// <exception cref="StringWhiteSpaceException"></exception>
        public static void Throw()
        {
            throw new StringWhiteSpaceException();
        }
    }
}

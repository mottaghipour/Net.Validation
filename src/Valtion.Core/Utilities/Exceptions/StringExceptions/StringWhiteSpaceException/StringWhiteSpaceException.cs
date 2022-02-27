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
        /// Constructor <see cref="StringWhiteSpaceException"/> without parameters
        /// </summary>
        public StringWhiteSpaceException() : base() { }

        /// <summary>
        /// Constructor <see cref="StringWhiteSpaceException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="message"></param>
        public StringWhiteSpaceException(string message) : base(message) { }

        /// <summary>
        /// Constructor <see cref="StringWhiteSpaceException"/> with <paramref name="message"/> and <paramref name="innerException"/>
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

        /// <summary>
        /// Throw <see cref="StringWhiteSpaceException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="message"></param>
        /// <exception cref="StringWhiteSpaceException"></exception>
        public static void Throw(string message)
        {
            throw new StringWhiteSpaceException(message);
        }

        /// <summary>
        /// Throw <see cref="StringWhiteSpaceException"/> with <paramref name="message"/> and <paramref name="innerException"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <exception cref="StringWhiteSpaceException"></exception>
        public static void Throw(string message, Exception innerException)
        {
            throw new StringWhiteSpaceException(message, innerException);
        }
    }
}

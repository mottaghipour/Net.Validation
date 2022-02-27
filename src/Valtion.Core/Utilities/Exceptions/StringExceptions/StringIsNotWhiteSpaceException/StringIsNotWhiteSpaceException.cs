using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtion.Core.Utilities.Exceptions.StringExceptions
{
    public class StringIsNotWhiteSpaceException : Exception
    {
        /// <summary>
        /// Constructor <see cref="StringIsNotWhiteSpaceException"/> without parameters
        /// </summary>
        public StringIsNotWhiteSpaceException() : base() { }

        /// <summary>
        /// Constructor <see cref="StringIsNotWhiteSpaceException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="Message"></param>
        public StringIsNotWhiteSpaceException(string message) : base(message) { }

        /// <summary>
        /// Constructor <see cref="StringIsNotWhiteSpaceException"/> with <paramref name="message"/> and <paramref name="innerException"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public StringIsNotWhiteSpaceException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Throw <see cref="StringIsNotWhiteSpaceException"/> without parameters
        /// </summary>
        /// <exception cref="StringIsNotWhiteSpaceException"></exception>
        public static void Throw()
        {
            throw new StringIsNotWhiteSpaceException();
        }

        /// <summary>
        /// Throw <see cref="StringIsNotWhiteSpaceException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="message"></param>
        /// <exception cref="StringIsNotWhiteSpaceException"></exception>
        public static void Throw(string message)
        {
            throw new StringIsNotWhiteSpaceException(message);
        }

        /// <summary>
        /// Throw <see cref="StringIsNotWhiteSpaceException"/> with <paramref name="message"/> and <paramref name="innerException"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <exception cref="StringIsNotWhiteSpaceException"></exception>
        public static void Throw(string message, Exception innerException)
        {
            throw new StringIsNotWhiteSpaceException(message, innerException);
        }
    }
}

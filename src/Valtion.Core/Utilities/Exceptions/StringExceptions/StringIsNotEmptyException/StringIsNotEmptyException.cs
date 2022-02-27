using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtion.Core.Utilities.Exceptions.StringExceptions
{
    public class StringIsNotEmptyException : Exception
    {
        /// <summary>
        /// Contractor <see cref="StringIsNotEmptyException"/> without parameters
        /// </summary>
        public StringIsNotEmptyException() : base() { }

        /// <summary>
        /// Contractor <see cref="StringIsNotEmptyException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="Message"></param>
        public StringIsNotEmptyException(string message) : base(message) { }

        /// <summary>
        /// Contractor <see cref="StringIsNotEmptyException"/> with <paramref name="message"/> and <paramref name="innerException"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public StringIsNotEmptyException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Throw <see cref="StringIsNotEmptyException"/> without parameters
        /// </summary>
        /// <exception cref="StringIsNotEmptyException"></exception>
        public static void Throw()
        {
            throw new StringIsNotEmptyException();
        }

        /// <summary>
        /// Throw <see cref="StringIsNotEmptyException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="message"></param>
        /// <exception cref="StringIsNotEmptyException"></exception>
        public static void Throw(string message)
        {
            throw new StringIsNotEmptyException(message);
        }

        /// <summary>
        /// Throw <see cref="StringIsNotEmptyException"/> with <paramref name="message"/> and <paramref name="innerException"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <exception cref="StringIsNotEmptyException"></exception>
        public static void Throw(string message, Exception innerException)
        {
            throw new StringIsNotEmptyException(message, innerException);
        }
    }
}

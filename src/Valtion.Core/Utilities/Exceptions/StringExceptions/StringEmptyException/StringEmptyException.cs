using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtion.Core.Utilities.Exceptions.StringExceptions
{
    public class StringEmptyException : Exception
    {
        /// <summary>
        /// Constructor <see cref="StringEmptyException"/> without parameters
        /// </summary>
        public StringEmptyException() : base() { }

        /// <summary>
        /// Constructor <see cref="StringEmptyException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="Message"></param>
        public StringEmptyException(string message) : base(message) { }


        /// <summary>
        /// Constructor <see cref="StringEmptyException"/> with <paramref name="message"/> and <paramref name="innerException"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public StringEmptyException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Throw <see cref="StringEmptyException"/> without parameters
        /// </summary>
        /// <exception cref="StringEmptyException"></exception>
        public static void Throw()
        {
            throw new StringEmptyException();
        }

        /// <summary>
        /// Throw <see cref="StringEmptyException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="message"></param>
        /// <exception cref="StringEmptyException"></exception>
        public static void Throw(string message)
        {
            throw new StringEmptyException(message);
        }

        /// <summary>
        /// Throw <see cref="StringEmptyException"/> with <paramref name="message"/> and <paramref name="innerException"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <exception cref="StringEmptyException"></exception>
        public static void Throw(string message, Exception innerException)
        {
            throw new StringEmptyException(message, innerException);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtion.Core.Utilities.Exceptions.StringExceptions
{
    public class StringNullReferenceException : Exception
    {
        /// <summary>
        /// Constructor <see cref="StringNullReferenceException"/> without parameters
        /// </summary>
        public StringNullReferenceException() : base() { }

        /// <summary>
        /// Constructor <see cref="StringNullReferenceException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="Message"></param>
        public StringNullReferenceException(string message) : base(message) { }

        /// <summary>
        /// Constructor <see cref="StringNullReferenceException"/> with <paramref name="message"/> and <paramref name="innerException"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public StringNullReferenceException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Throw <see cref="StringNullReferenceException"/> without parameters
        /// </summary>
        /// <exception cref="StringNullReferenceException"></exception>
        public static void Throw()
        {
            throw new StringNullReferenceException();
        }

        /// <summary>
        /// Throw <see cref="StringNullReferenceException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="message"></param>
        /// <exception cref="StringNullReferenceException"></exception>
        public static void Throw(string message)
        {
            throw new StringNullReferenceException(message);
        }

        /// <summary>
        /// Throw <see cref="StringNullReferenceException"/> with <paramref name="message"/> and <paramref name="innerException"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <exception cref="StringNullReferenceException"></exception>
        public static void Throw(string message, Exception innerException)
        {
            throw new StringNullReferenceException(message, innerException);
        }
    }
}

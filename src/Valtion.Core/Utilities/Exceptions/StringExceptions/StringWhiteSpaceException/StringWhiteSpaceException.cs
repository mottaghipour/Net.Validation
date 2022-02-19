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

        public StringWhiteSpaceException(string message) : base(message) { }
    }
}

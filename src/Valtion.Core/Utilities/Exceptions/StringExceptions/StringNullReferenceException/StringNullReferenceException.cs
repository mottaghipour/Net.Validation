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
        /// Contractor <see cref="StringNullReferenceException"/> without parameters
        /// </summary>
        public StringNullReferenceException() : base() { }

        public StringNullReferenceException(string Message) : base(Message) { }
    }
}

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
    }
}

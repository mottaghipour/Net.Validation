﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtion.Core.Utilities.Exceptions.StringExceptions
{
    public class StringIsNotWhiteSpaceException : Exception
    {
        /// <summary>
        /// Contractor <see cref="StringIsNotWhiteSpaceException"/> without parameters
        /// </summary>
        public StringIsNotWhiteSpaceException() : base() { }

        /// <summary>
        /// Contractor <see cref="StringIsNotWhiteSpaceException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="Message"></param>
        public StringIsNotWhiteSpaceException(string message) : base(message) { }
    }
}

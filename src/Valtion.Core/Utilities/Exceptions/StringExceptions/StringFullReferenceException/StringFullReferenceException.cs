﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtion.Core.Utilities.Exceptions.StringExceptions
{
    public class StringFullReferenceException : Exception
    {
        /// <summary>
        /// Contractor <see cref="StringFullReferenceException"/> without parameters
        /// </summary>
        public StringFullReferenceException() : base() { }

        /// <summary>
        /// Contractor <see cref="StringFullReferenceException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="Message"></param>
        public StringFullReferenceException(string message) : base(message) { }

        /// <summary>
        /// Contractor <see cref="StringFullReferenceException"/> with <paramref name="message"/> and <paramref name="innerException"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public StringFullReferenceException(string message, Exception innerException) : base(message, innerException) { }

    }
}

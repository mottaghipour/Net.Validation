﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;
using Xunit;

namespace Valtion.Core.Tests.Utilities.Exceptions.StringExceptions
{
    public class StringIsNotWhiteSpaceException_Tests
    {
        [Fact]
        public void Throw_StringIsNotWhiteSpaceException_Without_Parameters()
        {
            //Action Throw = () => throw new StringIsNotWhiteSpaceException();

            //Assert.Throws<StringIsNotWhiteSpaceException>(Throw);
        }

        [Fact]
        public void Throw_StringIsNotWhiteSpaceException_With_Message()
        {
            // string message = "String is not white space exception occurred;";

            //Action Throw = () => throw new StringIsNotWhiteSpaceException(message);

            //Assert.Throws<StringIsNotWhiteSpaceException>(Throw);
        }
    }
}

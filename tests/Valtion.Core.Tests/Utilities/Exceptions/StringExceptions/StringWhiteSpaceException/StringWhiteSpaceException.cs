using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;
using Xunit;

namespace Valtion.Core.Tests.Utilities.Exceptions.StringExceptions
{
    public class StringWhiteSpaceException_Tests
    {
        [Fact]
        public void Throw_StringWhiteSpaceException_Without_Parameters()
        {
            Action Throw = () => throw new StringWhiteSpaceException();

            Assert.Throws<StringWhiteSpaceException>(Throw);
        }        
        
        [Fact]
        public void Throw_StringWhiteSpaceException_With_Message()
        {
            string message = "String white space exception occurred;";

            Action Throw = () => throw new StringWhiteSpaceException(message);

            Assert.Throws<StringWhiteSpaceException>(Throw);
        }        
        
        [Fact]
        public void Throw_StringWhiteSpaceException_With_MessageAndInnerException()
        {
            try
            {
                throw new StringWhiteSpaceException();
            }
            catch (StringWhiteSpaceException innerException)
            {
                string message = "String white space exception occurred;";

                Action Throw = () => throw new StringWhiteSpaceException(message, innerException);

                Assert.Throws<StringWhiteSpaceException>(Throw);
            }
        }

        [Fact]
        public void ThrowMethod_StringWhiteSpaceException_Without_Parameters()
        {
            Action Throw = () => StringWhiteSpaceException.Throw();

            Assert.Throws<StringWhiteSpaceException>(Throw);
        }
    }
}

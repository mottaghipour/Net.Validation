using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Valtion.Core.Utilities.Exceptions.StringExceptions;

namespace Valtion.Core.Tests.Utilities.Exceptions.StringExceptions
{
    public class StringNullReferenceException_Tests
    {
        [Fact]
        public void Throw_StringNullReferenceException_Without_Parameters()
        {
            Action Throw = () => throw new StringNullReferenceException();

            Assert.Throws<StringNullReferenceException>(Throw);
        }

        [Fact]
        public void Throw_StringNullReferenceException_With_Message()
        {
            string message = "String null reference exception occurred;";

            Action Throw = () => throw new StringNullReferenceException(message);

            Assert.Throws<StringNullReferenceException>(Throw);
        }

        [Fact]
        public void Throw_StringNullReferenceException_With_MessageAndInnerException()
        {
            try
            {
                throw new StringNullReferenceException();
            }
            catch (StringNullReferenceException innerException)
            {
                string message = "String null reference exception occurred;";

                Action Throw = () => throw new StringNullReferenceException(message, innerException);

                Assert.Throws<StringNullReferenceException>(Throw);
            }
        }

        [Fact]
        public void ThrowMethod_StringNullReferenceException_Without_Parameters()
        {
            Action Throw = () => StringNullReferenceException.Throw();

            Assert.Throws<StringNullReferenceException>(Throw);
        }
    }
}

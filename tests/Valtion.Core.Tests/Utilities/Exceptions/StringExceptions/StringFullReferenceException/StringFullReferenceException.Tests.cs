using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;
using Xunit;

namespace Valtion.Core.Tests.Utilities.Exceptions.StringExceptions
{
    public class StringFullReferenceException_Tests
    {
        [Fact]
        public void Throw_StringFullReferenceException_Without_Parameters()
        {
            Action Throw = () => throw new StringFullReferenceException();

            Assert.Throws<StringFullReferenceException>(Throw);
        }        
        
        [Fact]
        public void Throw_StringFullReferenceException_With_Message()
        {
            string message = "String full reference exception occurred;";

            Action Throw = () => throw new StringFullReferenceException(message);

            Assert.Throws<StringFullReferenceException>(Throw);
        }        
        
        [Fact]
        public void Throw_StringFullReferenceException_With_MessageAndInnerException()
        {
            try
            {
                throw new StringFullReferenceException();
            }
            catch (StringFullReferenceException innerException)
            {
                string message = "String full reference exception occurred;";

                Action Throw = () => throw new StringFullReferenceException(message, innerException);

                Assert.Throws<StringFullReferenceException>(Throw);
            }
        }

        [Fact]
        public void ThrowMethod_StringFullReferenceException_Without_Parameters()
        {
            //Action Throw = () => StringFullReferenceException.Throw();

            //Assert.Throws<StringFullReferenceException>(Throw);
        }
    }
}

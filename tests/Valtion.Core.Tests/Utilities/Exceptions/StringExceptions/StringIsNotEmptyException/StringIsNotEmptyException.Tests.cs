using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Valtion.Core.Tests.Utilities.Exceptions.StringExceptions
{
    public class StringIsNotEmptyException_Tests
    {
        [Fact]
        public void Throw_StringIsNotEmptyException_Without_Parameters()
        {
            //Action Throw = () => throw new StringIsNotEmptyException();

            //Assert.Throws<StringIsNotEmptyException>(Throw);
        }

        [Fact]
        public void Throw_StringIsNotEmptyException_With_Message()
        {
            //string message = "String is not empty exception occurred;";

            //Action Throw = () => throw new StringIsNotEmptyException(message);

            //Assert.Throws<StringIsNotEmptyException>(Throw);
        }

        [Fact]
        public void Throw_StringIsNotEmptyException_With_MessageAndInnerException()
        {
            //try
            //{
            //    throw new StringIsNotEmptyException();
            //}
            //catch (StringIsNotEmptyException innerException)
            //{
            //    string message = "String is not empty exception occurred;";

            //    Action Throw = () => throw new StringIsNotEmptyException(message, innerException);

            //    Assert.Throws<StringIsNotEmptyException>(Throw);
            //}
        }

        [Fact]
        public void ThrowMethod_StringIsNotEmptyException_Without_Parameters()
        {
            //Action Throw = () => StringIsNotEmptyException.Throw();

            //Assert.Throws<StringIsNotEmptyException>(Throw);
        }
    }
}

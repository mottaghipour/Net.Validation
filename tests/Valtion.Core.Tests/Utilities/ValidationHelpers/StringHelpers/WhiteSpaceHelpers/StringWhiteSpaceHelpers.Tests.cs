using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;
using Valtion.Core.Utilities.ValidationHelpers.StringHelpers;
using Xunit;

namespace Valtion.Core.Tests.Utilities.ValidationHelpers.StringHelpers
{
    public class StringWhiteSpaceHelpers_Tests
    {
        [Fact]
        public void ShouldBeWhiteSpace_WithWhiteSpaceString_Valid()
        {
            string value = " ";

            string result = value.ShouldBeWhiteSpace();

            Assert.Equal(value, result);
        }

        [Fact]
        public void ShouldBeWhiteSpace_WithFullString_ThrowException()
        {
            string value = "value";

            Action Throw = () => value.ShouldBeWhiteSpace();

            Assert.Throws<StringIsNotWhiteSpaceException>(Throw);
        }

        [Fact]
        public void ShouldBeWhiteSpace_WithFullString_ThrowExceptionWithCustomMessage()
        {
            string message = "String is not white space;";

            try
            {
                string value = "value";

                value.ShouldBeWhiteSpace(message);
            }
            catch (StringIsNotWhiteSpaceException exception)
            {
                Assert.Equal(message, exception.Message);
            }
        }

        [Fact]
        public void ShouldNotBeWhiteSpace_WithFullString_Valid()
        {
            string value = "String";

            string result = value.ShouldNotBeWhiteSpace();

            Assert.Equal(value, result);
        }

        [Fact]
        public void ShouldNotBeWhiteSpace_WithWhiteSpaceString_ThrowException()
        {
            string value = " ";

            Action Throw = () => value.ShouldNotBeWhiteSpace();

            Assert.Throws<StringWhiteSpaceException>(Throw);
        }

        [Fact]
        public void ShouldNotBeWhiteSpace_WithWhiteSpaceString_ThrowExceptionWithCustomMessage()
        {
            string message = "String is white space;";

            try
            {
                string value = " ";

                value.ShouldNotBeWhiteSpace(message);
            }
            catch (StringWhiteSpaceException exception)
            {
                Assert.Equal(message, exception.Message);
            }
        }
    }
}

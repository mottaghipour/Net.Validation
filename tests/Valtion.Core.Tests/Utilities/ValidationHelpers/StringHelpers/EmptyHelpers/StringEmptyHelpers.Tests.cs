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
    public class StringEmptyHelpers_Tests
    {
        [Fact]
        public void ShouldBeEmpty_WithEmptyString_Valid()
        {
            string? value = "";

            string result = value.ShouldBeEmpty();

            Assert.Equal(value, result);
        }

        [Fact]
        public void ShouldBeEmpty_WithFullString_ThrowException()
        {
            string value = "value";

            Action Throw = () => value.ShouldBeEmpty();

            Assert.Throws<StringIsNotEmptyException>(Throw);
        }

        [Fact]
        public void ShouldBeEmpty_WithFullString_ThrowExceptionWithCustomMessage()
        {
            string message = "String is not empty;";

            try
            {
                string value = "value";

                value.ShouldBeEmpty(message);
            }
            catch (StringIsNotEmptyException exception)
            {
                Assert.Equal(message, exception.Message);
            }
        }

        [Fact]
        public void ShouldNotBeEmpty_WithFullString_Valid()
        {
            string value = "value";

            string result = value.ShouldNotBeEmpty();

            Assert.Equal(value, result);
        }

        [Fact]
        public void ShouldNotBeEmpty_WithEmptyString_ThrowException()
        {
            string value = "";

            Action Throw = () => value.ShouldNotBeEmpty();

            Assert.Throws<StringEmptyException>(Throw);
        }

        [Fact]
        public void ShouldNotBeEmpty_WithEmptyString_ThrowExceptionWithCustomMessage()
        {
            string message = "String is empty;";

            try
            {
                string value = "";

                value.ShouldNotBeEmpty(message);
            }
            catch (StringEmptyException exception)
            {
                Assert.Equal(message, exception.Message);
            }
        }
    }
}

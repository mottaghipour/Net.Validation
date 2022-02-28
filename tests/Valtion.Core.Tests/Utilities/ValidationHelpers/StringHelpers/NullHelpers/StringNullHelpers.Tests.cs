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
    public class StringNullHelpers_Tests
    {
        [Fact]
        public void ShouldBeNull_WithNullString_Valid()
        {
            string? value = null;

            string result = value.ShouldBeNull();

            Assert.Equal(value, result);
        }

        [Fact]
        public void ShouldBeNull_WithFullString_ThrowException()
        {
            string value = "value";

            Action Throw = () => value.ShouldBeNull();

            Assert.Throws<StringFullReferenceException>(Throw);
        }

        [Fact]
        public void ShouldBeNull_WithFullString_ThrowExceptionWithCustomMessage()
        {
            string message = "String is full;";

            try
            {
                string value = "value";

                value.ShouldBeNull(message);
            }
            catch (StringNullReferenceException exception)
            {
                Assert.Equal(message, exception.Message);
            }
        }

        [Fact]
        public void ShouldNotBeNull_WithFullString_Valid()
        {
            string value = "value";

            string result = value.ShouldNotBeNull();

            Assert.Equal(value, result);
        }        
        
        [Fact]
        public void ShouldNotBeNull_WithNullString_ThrowException()
        {
            string? value = null;

            Action Throw = () => value.ShouldNotBeNull();

            Assert.Throws<StringNullReferenceException>(Throw);
        }        
        
        [Fact]
        public void ShouldNotBeNull_WithNullString_ThrowExceptionWithCustomMessage()
        {
            string message = "String is null;";

            try
            {
                string? value = null;

                value.ShouldNotBeNull(message);
            }
            catch (StringNullReferenceException exception)
            {
                Assert.Equal(message, exception.Message);
            }
        }
    }
}

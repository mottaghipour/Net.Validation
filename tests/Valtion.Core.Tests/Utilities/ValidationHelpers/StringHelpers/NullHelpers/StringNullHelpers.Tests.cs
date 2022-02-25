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
        public void String_ShouldNotBeNull_Valid()
        {
            string value = "Value";

            string result = value.ShouldNotBeNull();

            Assert.Equal(value, result);
        }        
        
        [Fact]
        public void String_ShouldNotBeNull_InValid()
        {
            string? value = null;

            Action Throw = () => value.ShouldNotBeNull();

            Assert.Throws<StringNullReferenceException>(Throw);
        }        
        
        [Fact]
        public void String_ShouldNotBeNull_InValid_With_CustomMessage()
        {
            string message = "String is null";

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

        [Fact]
        public void String_ShouldBeNull_Valid()
        {
            string? value = null;

            string result = value.ShouldBeNull();

            Assert.Equal(value, result);
        }
    }
}

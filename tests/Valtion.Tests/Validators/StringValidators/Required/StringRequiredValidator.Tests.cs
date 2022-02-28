using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;
using Valtion.Validators.StringValidators;
using Xunit;

namespace Valtion.Tests.Validators.StringValidators
{
    public class StringRequiredValidator_Tests
    {
        [Fact]
        public void String_Required_With_ValidValue()
        {
            string value = "String value";

            string result = value.Required();

            Assert.Equal(value, result);
        }

        [Fact]
        public void String_Required_With_NullValue_ThrowException()
        {
            string? value = null;

            Action action = () => value.Required();

            Assert.Throws<StringNullReferenceException>(action);
        }        
        
        [Fact]
        public void String_Required_With_EmptyValue_ThrowException()
        {
            string? value = "";

            Action action = () => value.Required();

            Assert.Throws<StringEmptyException>(action);
        }  
        
        [Fact]
        public void String_Required_With_WhiteSpaceValue_ThrowException()
        {
            string? value = " ";

            Action action = () => value.Required();

            Assert.Throws<StringWhiteSpaceException>(action);
        }
    }
}

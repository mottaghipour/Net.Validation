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
        public void Required_WithValidString_Valid()
        {
            string value = "String value";

            string result = value.Required();

            Assert.Equal(value, result);
        }

        [Fact]
        public void Required_WithNullString_ThrowException()
        {
            string value = null;

            Action action = () => value.Required();

            Assert.Throws<StringNullReferenceException>(action);
        }        
        
        [Fact]
        public void Required_WithEmptyString_ThrowException()
        {
            string? value = "";

            Action action = () => value.Required();

            Assert.Throws<StringEmptyException>(action);
        }  
        
        [Fact]
        public void Required_WithWhiteSpaceString_ThrowException()
        {
            string? value = " ";

            Action action = () => value.Required();

            Assert.Throws<StringWhiteSpaceException>(action);
        }
    }
}

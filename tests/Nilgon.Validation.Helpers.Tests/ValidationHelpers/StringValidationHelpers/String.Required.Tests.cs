using System;
using Xunit;
using Nilgon.Validation.Helpers.Exceptions;

namespace Nilgon.Validation.Helpers.Tests.ValidationHelpers.StringValidationHelpers
{
    public class StringValidationHelpers_Required_Tests
    {
        [Fact]
        public void Required_With_Valid_Value()
        {
            string value = "Test value";

            string result = value.Required();

            Assert.Equal(value, result);
        }

        [Fact]
        public void Required_With_Null_Value_ThrowException()
        {
            string value = null;

            Action action = () => value.Required();

            Assert.Throws<NilgonValidationException>(action);
        }

        [Fact]
        public void Required_With_Empty_Value_ThrowException()
        {
            string value = "";

            Action action = () => value.Required();

            Assert.Throws<NilgonValidationException>(action);
        }

        [Fact]
        public void Required_With_WhiteSpace_Value_ThrowException()
        {
            string value = " ";

            Action action = () => value.Required();

            Assert.Throws<NilgonValidationException>(action);
        }
    }
}

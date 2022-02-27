using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;
using Xunit;

namespace Valtion.Core.Tests.Utilities.ValidationHelpers.StringHelpers
{
    public class StringEmptyHelpers_Tests
    {
        [Fact]
        public void String_ShouldBeEmpty_Valid()
        {
            //string? value = "";

            //string result = value.ShouldBeEmpty();

            //Assert.Equal(value, result);
        }

        [Fact]
        public void String_ShouldBeEmpty_InValid()
        {
            //string? value = "value";

            //Action Throw = () => value.ShouldBeEmpty();

            //Assert.Throws<StringIsNotEmptyException>(Throw);
        }

        [Fact]
        public void String_ShouldBeEmpty_InValid_With_CustomMessage()
        {
            //string message = "String is not empty;";

            //try
            //{
            //    string? value = null;

            //    value.ShouldBeEmpty(message);
            //}
            //catch (StringIsNotEmptyException exception)
            //{
            //    Assert.Equal(message, exception.Message);
            //}
        }
    }
}

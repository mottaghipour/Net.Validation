using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Validators.StringValidators;
using Xunit;

namespace Valtion.Tests.Validators.StringValidators
{
    public class StringRequiredValidator_Tests
    {
        [Fact]
        public void String_Required_Valid()
        {
            string value = "String value";

            string result = value.Required();

            Assert.Equal(value, result);
        }
    }
}

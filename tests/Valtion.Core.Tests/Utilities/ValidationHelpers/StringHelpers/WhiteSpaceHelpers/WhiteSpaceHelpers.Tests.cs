using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.ValidationHelpers.StringHelpers;
using Xunit;

namespace Valtion.Core.Tests.Utilities.ValidationHelpers.StringHelpers
{
    public class WhiteSpaceHelpers_Tests
    {
        [Fact]
        public void String_ShouldBeWhiteSpace_Valid()
        {
            string? value = " ";

            string result = value.ShouldBeWhiteSpace();

            Assert.Equal(value, result);
        }
    }
}

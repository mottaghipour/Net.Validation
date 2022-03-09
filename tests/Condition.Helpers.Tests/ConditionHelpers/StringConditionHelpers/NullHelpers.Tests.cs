using System;
using Nilgon.Net.Condition.Helpers;
using Xunit;

namespace Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers
{
	public class NullHelpers
	{
        [Fact]
        public void IsNull_WithNullValue_ReturnTrue()
        {
            string? value = null;

            bool result = value.IsNull();

            Assert.True(result);
        }

        [Fact]
        public void IsNull_WithFullValue_ReturnFalse()
        {
            string? value = "Full value";

            bool result = value.IsNull();

            Assert.False(result);
        }

        [Fact]
        public void IsNotNull_WithNullValue_ReturnFalse()
        {
            string? value = null;

            bool result = value.IsNotNull();

            Assert.False(result);
        }

        [Fact]
        public void IsNotNull_WithFullValue_ReturnTrue()
        {
            string? value = "Full value";

            bool result = value.IsNotNull();

            Assert.True(result);
        }
    }
}

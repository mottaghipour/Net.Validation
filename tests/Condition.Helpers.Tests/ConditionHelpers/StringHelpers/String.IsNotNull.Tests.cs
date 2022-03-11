using Xunit;

namespace Nilgon.Net.Condition.Helpers.StringHelpers.Tests
{
    public class StringIsNotNullTests
    {
        [Fact]
        public void NullString_ReturnFalse()
        {
            string value = null;

            bool result = value.IsNotNull();

            Assert.False(result);
        }

        [Fact]
        public void FullString_ReturnTrue()
        {
            string value = "String";

            bool result = value.IsNotNull();

            Assert.True(result);
        }
    }
}

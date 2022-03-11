using Xunit;

namespace Nilgon.Net.Condition.Helpers.StringHelpers.Tests
{
    public class StringIsNullTests
    {
        [Fact]
        public void NullString_ReturnTrue()
        {
            string value = null;

            bool result = value.IsNull();

            Assert.True(result);
        }

        [Fact]
        public void FullString_ReturnFalse()
        {
            string value = "String";

            bool result = value.IsNull();

            Assert.False(result);
        }
    }
}

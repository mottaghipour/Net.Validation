using Xunit;

namespace Nilgon.Net.Condition.Helpers.StringHelpers.Tests
{
	public class StringIsNotEmptyTests
	{
        [Fact]
        public void EmptyString_ReturnFalse()
        {
            string value = "";

            bool result = value.IsNotEmpty();

            Assert.False(result);
        }

        [Fact]
        public void NullString_ReturnTrue()
        {
            string value = null;

            bool result = value.IsNotEmpty();

            Assert.True(result);
        }
    }
}

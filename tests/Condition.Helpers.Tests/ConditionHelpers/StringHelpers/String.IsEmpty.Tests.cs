using Xunit;

namespace Nilgon.Net.Condition.Helpers.StringHelpers.Tests
{
	public class StringIsEmptyTests
	{
        [Fact]
        public void EmptyString_ReturnTrue()
        {
            string value = "";

            bool result = value.IsEmpty();

            Assert.True(result);
        }

        [Fact]
        public void NullString_ReturnFalse()
        {
            string value = null;

            bool result = value.IsEmpty();

            Assert.False(result);
        }
    }
}

using Nilgon.Condition.Helpers;

namespace Nilgon.Validation.Helpers
{
    public static partial class CommonValidationHelpers
    {
        private const string ShouldNotBeNullMessage = "The value should not be null.";
        public static T ShouldNotBeNull<T>(this T value, string message = ShouldNotBeNullMessage)
        {
            if (value.IsNull())
            {
                ThrowException(message);
            }

            return value;
        }
    }
}

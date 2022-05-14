using Nilgon.Condition.Helpers;

namespace Nilgon.Validation.Helpers;

public static partial class CommonValidationHelpers
{
    private const string ShouldBeNullMessage = "The value should be null.";
    public static T ShouldBeNull<T>(this T value, string message = ShouldBeNullMessage)
    {
        if (value.IsNotNull())
        {
            ThrowException(message);
        }

        return value;
    }
}

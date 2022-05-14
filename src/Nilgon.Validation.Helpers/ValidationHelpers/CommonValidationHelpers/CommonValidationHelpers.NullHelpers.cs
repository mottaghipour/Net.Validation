using Nilgon.Condition.Helpers;

namespace Nilgon.Validation.Helpers;

public static partial class CommonValidationHelpers
{
    private const string MustBeNullMessage = "The value must be null.";
    public static T MustBeNull<T>(this T value, string? message = MustBeNullMessage)
    {
        if (value.IsNotNull())
        {
            ThrowException(message);
        }

        return value;
    }

    private const string MustNotBeNullMessage = "The value must not be null.";
    public static T MustNotBeNull<T>(this T value, string? message = MustNotBeNullMessage)
    {
        if (value.IsNull())
        {
            ThrowException(message);
        }

        return value;
    }
}

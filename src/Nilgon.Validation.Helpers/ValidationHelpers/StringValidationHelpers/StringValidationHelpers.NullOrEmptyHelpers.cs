using Nilgon.Condition.Helpers;

namespace Nilgon.Validation.Helpers;

public static partial class StringValidationHelpers
{
    private const string MustBeNullOrEmptyMessage = "test message";
    public static string MustBeNullOrEmpty(this string value, string? message = MustBeNullOrEmptyMessage)
    {
        if (value.IsNotNullOrEmpty())
        {
            ThrowException(message);
        }

        return value;
    }

    private const string MustNotBeNullOrEmptyMessage = "test message";
    public static string MustNotBeNullOrEmpty(this string value, string? message = MustNotBeNullOrEmptyMessage)
    {
        if (value.IsNullOrEmpty())
        {
            ThrowException(message);
        }

        return value;
    }
}

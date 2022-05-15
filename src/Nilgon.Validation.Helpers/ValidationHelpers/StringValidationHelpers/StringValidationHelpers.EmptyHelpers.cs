using Nilgon.Condition.Helpers;

namespace Nilgon.Validation.Helpers;

public static partial class StringValidationHelpers
{
    private const string MustBeEmptyMessage = "test message";
    public static string MustBeEmpty(this string value, string? message = MustBeEmptyMessage)
    {
        if (value.IsNotEmpty())
        {
            ThrowException(message);
        }

        return value;
    }

    private const string MustNotBeEmptyMessage = "test message";
    public static string MustNotBeEmpty(this string value, string? message = MustNotBeEmptyMessage)
    {
        if (value.IsEmpty())
        {
            ThrowException(message);
        }

        return value;
    }
}

using Nilgon.Condition.Helpers;

namespace Nilgon.Validation.Helpers;

public static partial class StringValidationHelpers
{
    private const string MustBeRequiredMessage = "The value field is required.";
    
    public static string MustBeRequired(this string value, string? message = MustBeRequiredMessage)
    {
        if (value.IsNullOrEmptyOrWhiteSpace())
        {
            ThrowException(message);
        }
        
        return value;
    }
}

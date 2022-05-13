using Nilgon.Condition.Helpers;

namespace Nilgon.Validation.Helpers
{
    public static partial class StringValidationHelpers
    {
        private const string RequiredMessage = "The value field is required.";
        
        public static string Required(this string value, string? message = RequiredMessage)
        {
            if (value.IsNullOrEmptyOrWhiteSpace())
            {
                ThrowException(message);
            }
            
            return value;
        }
    }
}

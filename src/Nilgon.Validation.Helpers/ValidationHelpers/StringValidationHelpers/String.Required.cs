using Nilgon.Validation.Helpers.Exceptions;

namespace Nilgon.Validation.Helpers
{
    public static partial class StringValidationHelpers
    {
        public static string Required(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new NilgonValidationException<string>(); 

            return value;
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Nilgon.Validation.Helpers.Utilities
{
    internal static class ExceptionLauncher
    {
        /// <summary>
        ///    Throws the specified exception.
        /// </summary>
        /// <param name="message"></param>
        /// <exception cref="ValidationException"></exception>
        internal static void ThrowValidationException(string? message)
        {
            var validationException = CreateValidationException(message);

            throw validationException;
        }

        /// <summary>
        ///   Creates the validation exception.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>
        ///   The <see cref="ValidationException" />.
        /// </returns>
        private static ValidationException CreateValidationException(string? message)
        {
            return new ValidationException(message);
        }
    }
}

using Nilgon.Validation.Helpers.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Nilgon.Validation.Helpers;

public static partial class StringValidationHelpers
{
    /// <summary>
    ///   ThrowException is a helper method that throws an exception if the condition is false.
    /// </summary>
    /// <param name="message"></param>
    /// <exception cref="ValidationException"></exception>
    private static void ThrowException(string? message)
    {
        ExceptionLauncher.ThrowValidationException(message);
    }
}

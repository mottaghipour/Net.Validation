namespace Nilgon.Validation.Helpers.Exceptions
{
    public class NilgonValidationException : Exception
    {
        public NilgonValidationException() : base() { }

        public NilgonValidationException(string? message) : base(message) { }

        public NilgonValidationException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}

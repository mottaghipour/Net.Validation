namespace Nilgon.Validation.Helpers.Exceptions
{
    public class NilgonValidationException : Exception
    {
        private NilgonValidationException() : base() { }

        private NilgonValidationException(string? message) : base(message) { }

        private NilgonValidationException(string? message, Exception? innerException) : base(message, innerException) { }

        public static string Throw()
        {
            throw new NilgonValidationException();
        }

        public static string Throw(string? message)
        {
            throw new NilgonValidationException(message);
        }

        public static string Throw(string? message, Exception? innerException)
        {
            throw new NilgonValidationException(message, innerException);
        }
    }
}

namespace Nilgon.Validation.Helpers.Exceptions
{
    public class NilgonValidationException : Exception
    {
        private NilgonValidationException() : base() { }

        private NilgonValidationException(string? message) : base(message) { }

        private NilgonValidationException(string? message, Exception? innerException) : base(message, innerException) { }

        public static NilgonValidationException Create() 
        {
            return new NilgonValidationException();
        }

        public static NilgonValidationException Create(string? message)
        {
            return new NilgonValidationException(message);
        }

        public static NilgonValidationException Create(string? message, Exception? innerException)
        {
            return new NilgonValidationException(message, innerException);
        }

        public static string Throw()
        {
            throw Create();
        }

        public static string Throw(string? message)
        {
            throw Create(message);
        }

        public static string Throw(string? message, Exception? innerException)
        {
            throw Create(message, innerException);
        }
    }
}

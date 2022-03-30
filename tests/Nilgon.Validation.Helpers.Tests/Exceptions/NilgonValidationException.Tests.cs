using Nilgon.Validation.Helpers.Exceptions;
using System;
using Xunit;

namespace Nilgon.Validation.Helpers.Tests.Exceptions
{
    public class NilgonValidationException_Tests
    {
        [Fact]
        public void Throw_NilgonValidationException()
        {
            Action action = () => NilgonValidationException.Throw();

            Assert.Throws<NilgonValidationException>(action);
        }

        [Fact]
        public void Throw_NilgonValidationException_WithMessage()
        {
            string message = "Test Message";
            
            try
            {
                NilgonValidationException.Throw(message);
            }
            
            catch (NilgonValidationException exception)
            {
                Assert.Equal(message, exception.Message);
            }
        }

        [Fact]
        public void Throw_NilgonValidationException_WithMessageAndInnerException()
        {
            string message = "Test Message";
            
            NilgonValidationException innerException = NilgonValidationException.Create();
            
            try
            {
                NilgonValidationException.Throw(message, innerException);
            }

            catch (NilgonValidationException exception)
            {
                Assert.Equal(message, exception.Message);
                Assert.Equal(innerException, exception.InnerException);
            }
        } 
    }
}

using Xunit;
using System;
using System.ComponentModel.DataAnnotations;

namespace Nilgon.Validation.Helpers.Tests.ValidationHelpers.CommonValidationHelpers.NullHelpers;

public sealed class MustNotBeNull_Validation_Helper_Tests
{
    [Fact]
    public void MustNotBeNull_ReturnsValue_WhenObjectIsNotNull()
    {
        object objectToTest = string.Empty;

        object result = objectToTest.MustNotBeNull();

        Assert.Equal(objectToTest, result);
    }

    [Fact]
    public void MustNotBeNull_ThrowException_WhenObjectIsNull()
    {
        object objectToTest = null;

        Action action = () => objectToTest.MustNotBeNull();

        Assert.Throws<ValidationException>(action);
    }
}

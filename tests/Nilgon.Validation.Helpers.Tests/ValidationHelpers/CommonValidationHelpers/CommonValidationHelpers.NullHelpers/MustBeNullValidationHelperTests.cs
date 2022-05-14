using System;
using Xunit;
using System.ComponentModel.DataAnnotations;

namespace Nilgon.Validation.Helpers.Tests.ValidationHelpers.CommonValidationHelpers.NullHelpers;

public sealed class MustBeNull_Validation_Helper_Tests
{
    [Fact]
    public void MustBeNull_ReturnsValue_WhenObjectIsNull()
    {
        object objectToTest = null;

        object result = objectToTest.MustBeNull();

        Assert.Equal(objectToTest, result);
    }

    [Fact]
    public void MustBeNull_ThrowException_WhenObjectIsNotNull()
    {
        object objectToTest = string.Empty;

        Action action = () => objectToTest.MustBeNull();

        Assert.Throws<ValidationException>(action);
    }
}

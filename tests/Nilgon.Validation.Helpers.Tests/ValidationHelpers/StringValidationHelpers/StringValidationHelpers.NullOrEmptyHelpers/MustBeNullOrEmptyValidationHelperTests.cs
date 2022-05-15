using Xunit;
using System;
using System.ComponentModel.DataAnnotations;

namespace Nilgon.Validation.Helpers.Tests.ValidationHelpers.StringValidationHelpers.NullOrEmptyHelpers;

public sealed class MustBeNullOrEmpty_Validation_Helper_Tests
{
    [Fact]
    public void MustBeNullOrEmpty_ReturnsValue_WhenStringIsNull()
    {
        string stringToTest = null;
        
        string result = stringToTest.MustBeNullOrEmpty();

        Assert.Equal(stringToTest, result);
    }

    [Fact]
    public void MustBeNullOrEmpty_ReturnsValue_WhenStringIsEmpty()
    {
        string stringToTest = string.Empty;

        string result = stringToTest.MustBeNullOrEmpty();

        Assert.Equal(stringToTest, result);
    }

    [Fact]
    public void MustBeNullOrEmpty_ThrowsException_WhenStringIsWhiteSpace()
    {
        string stringToTest = " ";

        Action action = () => stringToTest.MustBeNullOrEmpty();

        Assert.Throws<ValidationException>(action);
    }

    [Fact]
    public void MustBeNullOrEmpty_ThrowsException_WhenStringIsFull()
    {
        string stringToTest = "test";

        Action action = () => stringToTest.MustBeNullOrEmpty();

        Assert.Throws<ValidationException>(action);
    }
}

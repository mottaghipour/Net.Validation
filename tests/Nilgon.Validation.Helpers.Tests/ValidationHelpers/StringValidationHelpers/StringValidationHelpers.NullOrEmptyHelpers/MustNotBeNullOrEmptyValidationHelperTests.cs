using Xunit;
using System;
using System.ComponentModel.DataAnnotations;

namespace Nilgon.Validation.Helpers.Tests.ValidationHelpers.StringValidationHelpers.NullOrEmptyHelpers;

public sealed class MustNotBeNullOrEmpty_Validation_Helper_Tests
{
    [Fact]
    public void MustNotBeNullOrEmpty_ReturnsValue_WhenStringIsWhiteSpace()
    {
        string stringToTest = " ";

        string result = stringToTest.MustNotBeNullOrEmpty();

        Assert.Equal(stringToTest, result);
    }

    [Fact]
    public void MustNotBeNullOrEmpty_ReturnsValue_WhenStringIsFull()
    {
        string stringToTest = "test";

        string result = stringToTest.MustNotBeNullOrEmpty();

        Assert.Equal(stringToTest, result);
    }

    [Fact]
    public void MustNotBeNullOrEmpty_ThrowsException_WhenStringIsNull()
    {
        string stringToTest = null;

        Action action = () => stringToTest.MustNotBeNullOrEmpty();

        Assert.Throws<ValidationException>(action);
    }

    [Fact]
    public void MustNotBeNullOrEmpty_ThrowsException_WhenStringIsEmpty()
    {
        string stringToTest = string.Empty;

        Action action = () => stringToTest.MustNotBeNullOrEmpty();

        Assert.Throws<ValidationException>(action);
    }
}

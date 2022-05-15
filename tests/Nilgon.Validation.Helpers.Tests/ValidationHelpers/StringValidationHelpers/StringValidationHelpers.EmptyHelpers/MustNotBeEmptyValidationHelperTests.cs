using System;
using Xunit;
using System.ComponentModel.DataAnnotations;

namespace Nilgon.Validation.Helpers.Tests.ValidationHelpers.StringValidationHelpers.EmptyHelpers;

public sealed class MustNotBeEmpty_Validation_Helper_Tests
{
    [Fact]
    public void MustNotBeEmpty_ReturnsValue_WhenStringIsNull()
    {
        string stringToTest = null;

        string result = stringToTest.MustNotBeEmpty();

        Assert.Equal(stringToTest, result);
    }

    [Fact]
    public void MustNotBeEmpty_ReturnsValue_WhenStringIsWhiteSpace()
    {
        string stringToTest = " ";

        string result = stringToTest.MustNotBeEmpty();

        Assert.Equal(stringToTest, result);
    }

    [Fact]
    public void MustNotBeEmpty_ReturnsValue_WhenStringIsFull()
    {
        string stringToTest = "test";

        string result = stringToTest.MustNotBeEmpty();

        Assert.Equal(stringToTest, result);
    }

    [Fact]
    public void MustNotBeEmpty_ThrowException_WhenStringIsEmpty()
    {
        string stringToTest = string.Empty;

        Action action = () => stringToTest.MustNotBeEmpty();

        Assert.Throws<ValidationException>(action);
    }
}

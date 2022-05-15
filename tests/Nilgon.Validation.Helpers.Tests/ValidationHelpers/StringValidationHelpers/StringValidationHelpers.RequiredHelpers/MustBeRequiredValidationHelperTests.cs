using Xunit;
using System;
using System.ComponentModel.DataAnnotations;

namespace Nilgon.Validation.Helpers.Tests.ValidationHelpers.StringValidationHelpers.RequiredHelpers;

public sealed class MustBeRequired_Validation_Helper_Tests
{
    [Fact]
    public void MustBeRequired_ReturnsValue_WhenStringIsFull()
    {
        string stringToTest = "test";

        string result = stringToTest.MustBeRequired();

        Assert.Equal(stringToTest, result);
    }

    [Fact]
    public void MustBeRequired_ThrowsException_WhenStringIsNull()
    {
        string stringToTest = null;

        Action action = () => stringToTest.MustBeRequired();

        Assert.Throws<ValidationException>(action);
    }

    [Fact]
    public void MustBeRequired_ThrowsException_WhenStringIsEmpty()
    {
        string stringToTest = "";

        Action action = () => stringToTest.MustBeRequired();

        Assert.Throws<ValidationException>(action);
    }

    [Fact]
    public void MustBeRequired_ThrowsException_WhenStringIsWhiteSpace()
    {
        string stringToTest = " ";

        Action action = () => stringToTest.MustBeRequired();

        Assert.Throws<ValidationException>(action);
    }
}

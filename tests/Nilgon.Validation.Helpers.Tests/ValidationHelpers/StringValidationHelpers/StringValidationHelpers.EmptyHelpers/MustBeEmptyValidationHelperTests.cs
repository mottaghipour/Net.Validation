﻿using Xunit;
using System;
using System.ComponentModel.DataAnnotations;

namespace Nilgon.Validation.Helpers.Tests.ValidationHelpers.StringValidationHelpers.EmptyHelpers;

public sealed class MustBeEmpty_Validation_Helper_Tests
{
    [Fact]
    public void MustBeEmpty_ReturnsValue_WhenStringIsEmpty()
    {
        string stringToTest = string.Empty;

        string result = stringToTest.MustBeEmpty();

        Assert.Equal(stringToTest, result);
    }

    [Fact]
    public void MustBeEmpty_ThrowsException_WhenStringIsNull()
    {
        string stringToTest = null;

        Action action = () => stringToTest.MustBeEmpty();

        Assert.Throws<ValidationException>(action);
    }

    [Fact]
    public void MustBeEmpty_ThrowsException_WhenStringIsWhiteSpace()
    {
        string stringToTest = " ";

        Action action = () => stringToTest.MustBeEmpty();

        Assert.Throws<ValidationException>(action);
    }

    [Fact]
    public void MustBeEmpty_ThrowsException_WhenStringIsFull()
    {
        string stringToTest = "test";

        Action action = () => stringToTest.MustBeEmpty();

        Assert.Throws<ValidationException>(action);
    }
}

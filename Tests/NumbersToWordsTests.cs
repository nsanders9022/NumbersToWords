using Xunit;
using NumbersApp.Objects;
using System;
using System.Collections.Generic;

namespace NumbersApp
{
  public class NumberTest
  {
    [Fact]
    public void NumberWord_OneDigit_Word()
    {
      //Arrange
      string oneDigit = "1";
      //Act
      Numbers newNumber = new Numbers(oneDigit);
      //Assert
      Assert.Equal("one", newNumber.NumberWord());
    }

    [Fact]
    public void NumberWord_DoubleDigit_Word()
    {
      //Arrange
      string twoDigit = "21";
      //Act
      Numbers newNumber = new Numbers(twoDigit);
      //Assert
      Assert.Equal("twenty one", newNumber.NumberWord());
    }

    [Fact]
    public void NumberWord_Hundred_Word()
    {
      //Arrange
      string twoDigit = "251";
      //Act
      Numbers newNumber = new Numbers(twoDigit);
      //Assert
      Assert.Equal("two hundred fifty one", newNumber.NumberWord());
    }

    [Fact]
    public void NumberWord_Zero_Word()
    {
      //Arrange
      string zeroDigit = "0";
      //Act
      Numbers newNumber = new Numbers(zeroDigit);
      //Assert
      Assert.Equal("zero", newNumber.NumberWord());
    }
  }
}

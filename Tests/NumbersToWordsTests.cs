using Xunit;
using NumbersApp.Objects;
using System;
using System.Collections.Generic;

namespace NumbersApp
{
  public class NumberTest 
  {
    // public void Dispose()
    // {
    //   Numbers.DeleteAll();
    // }
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

    }
  }

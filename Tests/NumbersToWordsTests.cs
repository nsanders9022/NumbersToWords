using Xunit;
using NumbersApp.Objects;

namespace NumbersApp
{
    public class NumberTest
    {
      [Fact]
      public void NumberWord_OneDigit_Word()
      {
        //Arrange
        int oneDigit = 1;
        //Act
        Numbers newNumber = new Numbers(oneDigit);
        //Assert
        Assert.Equal("one", newNumber.NumberWord());
      }
    }
  }

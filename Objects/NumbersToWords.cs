using System;
using System.Collections.Generic;

namespace NumbersApp.Objects

{
  public class Numbers
  {
    public string _number;
    public static Dictionary<char, string> singleDict = new Dictionary<char, string>()
    {
      {'0', ""},
      {'1', "one"},
      {'2', "two"},
      {'3', "three"},
      {'4', "four"},
      {'5', "five"},
      {'6', "six"},
      {'7', "seven"},
      {'8', "eight"},
      {'9', "nine"},
    };

    public static Dictionary<char, string> doubleDict = new Dictionary<char, string>()
    {
      {'2', "twenty"},
      {'3', "thirty"},
      {'4', "forty"},
      {'5', "fifty"},
      {'6', "sixty"},
      {'7', "seventy"},
      {'8', "eighty"},
      {'9', "ninety"},
    };
    public static Dictionary<char, string> hundredDict = new Dictionary<char, string>()
    {
      {'1', "one hundred"},
      {'2', "two hundred"},
      {'3', "three hundred"},
      {'4', "four hundred"},
      {'5', "five hundred"},
      {'6', "six hundred"},
      {'7', "seven hundred"},
      {'8', "eight hundred"},
      {'9', "nine hundred"},
    };

    public static Dictionary<char, string> teenDict = new Dictionary<char, string>()
    {
      {'1', "eleven"},
      {'2', "twelve"},
      {'3', "thirteen"},
      {'4', "forteen"},
      {'5', "fifteen"},
      {'6', "sixteen"},
      {'7', "seventeen"},
      {'8', "eighteen"},
      {'9', "nineteen"},
    };


    //constructor
    public Numbers(string newNumber)
    {
      _number = newNumber;
    }

    //Getter
    public string GetNumber()
    {
      return _number;
    }

    //Main method
    public string NumberWord()
    {
      char[] numberArray = GetNumber().ToCharArray();
      string result = "";

      if (numberArray.Length >2)
      {
        foreach (KeyValuePair<char, string> pair in hundredDict)
        {
          if (pair.Key == numberArray[numberArray.Length-3])
          {
            result += pair.Value + " ";
          }
        }
      }

      if (numberArray.Length >1)
      {
        foreach (KeyValuePair<char, string> pair in doubleDict)
        {
          if (pair.Key == numberArray[numberArray.Length-2])
          {
            result += pair.Value + " ";
          }
        }
      }
      if ((numberArray.Length == 1) && (numberArray[0] == '0'))
      {
        result = "zero";
      }

      foreach (KeyValuePair<char, string> pair in singleDict)
      {
        if (pair.Key == numberArray[numberArray.Length-1])
        {
          result += pair.Value;
        }
      }
      return result;
    }
  }
}

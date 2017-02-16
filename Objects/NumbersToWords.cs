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

using System;
using System.Collections.Generic;

namespace NumbersApp.Objects

{
  public class Numbers
  {
    public int number;
    public static Dictionary<int, string> singleDict = new Dictionary<int, string>()
    {
      {0, ""},
      {1, "one"},
      {2, "two"},
      {3, "three"},
      {4, "four"},
      {5, "five"},
      {6, "six"},
      {7, "seven"},
      {8, "eight"},
      {9, "nine"},
    };

    //constructor
    public Numbers(int newNumber)
    {
      number = newNumber;
    }

    //Getter
    public int GetNumber()
    {
      return number;
    }

    public string NumberWord()
    {
      foreach (KeyValuePair<int, string> pair in singleDict)
      {
        if (pair.Key == number)
        {
          return pair.Value;
        }
      }
      return "error";
    }
  }
}

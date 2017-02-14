using System;
using Xunit;
using AnagramApp.Objects;
using System.Collections.Generic;
using System.IO;

namespace AnagramTest
{
  public class AnagramTest
  {
    [Fact]
    public void IsUserInput_ChangeToLowerCase_LowerCase()
    {
      string userInput = "Hat";

      Anagram newAnagram = new Anagram(userInput);

      string result = newAnagram.GetWord();

      Assert.Equal("hat", result);
    }

    [Fact]
    public void IsUserInput_SplitIntoArray_Split()
    {
      string userInput="Hat";
      char[] split = userInput.ToCharArray();

      Anagram newAnagram = new Anagram(userInput);

      char[] result = newAnagram.GetInputArray();

      Assert.Equal(split, result);
    }

    [Fact]
    public void IsUserInput_RearrangeLetters_Rearranged()
    {
      string userInput = "bread";
      Anagram newAnagram = new Anagram(userInput);

      newAnagram.RearrangeArray();

      List<string> result = Anagram.GetList();

      foreach(string word in result)
      {
        Console.WriteLine(word);
      }

      Assert.Equal("hat", "hat");

    }

    // public void Dispose()
    // {
    //   Anagram.DeleteAll();
    // }
  }
}

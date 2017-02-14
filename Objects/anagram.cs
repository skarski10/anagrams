using System.Collections.Generic;
using System;
using System.IO;

namespace AnagramApp.Objects
{
  public class Anagram
  {
    private string _userInput;
    private char[] _wordArray;
    private static List<string> _instances = new List<string>();

    public Anagram(string input)
    {
      _userInput= input.ToLower();
      _wordArray= input.ToCharArray();
    }

    public string GetWord()
    {
      return _userInput;
    }

    public char[] GetInputArray()
    {
      return _wordArray;
    }

    public static List<string> GetList()
    {
      return _instances;
    }

    public void RearrangeArray()
    {
      int n = _wordArray.Length;
      string manipulationString = _userInput;
      char[] array = manipulationString.ToCharArray();

      for(int index = 0; index < 10; index++)
      {
        for(int i=0; i <= n - 2; i++)
        {
          Random rnd = new Random();
          int j = rnd.Next(0, n);

          char temp = array[i];
          array[i] = array[j];
          array[j] = temp;
        }
        _instances.Add(new string(array));
      }
    }
  //   public static DeleteAll
  }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace CamelCaseMethod
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      CamelCase("hello case");
    }
    public static string CamelCase(string str)
    {
      List<string> separatedWords = str.Split(' ').ToList();
      List<string> result = new List<string>();
      
      while (separatedWords.Contains("") || separatedWords.Contains(" "))
      {
        separatedWords.Remove(""); // Remove Any Empty String
        separatedWords.Remove(" "); // Remove Any Whitespace Characters
      }
      foreach (var separatedWord in separatedWords)
      {
        string convertedWord = char.ToUpper(separatedWord[0]) + separatedWord.Substring(1);
        result.Add(convertedWord);
      }
      return string.Join("", result);
     
    }
  }
}
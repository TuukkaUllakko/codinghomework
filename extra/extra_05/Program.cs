using System;
using System.Collections.Generic;

namespace extra_05
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      for (int i = 1; i <= 5; i++)
      {
        Console.WriteLine(i);
      }

      List<string> words = new List<string>();
      Console.WriteLine("Give words, 'end' quits:");
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "end")
        {
          break;
        }
        words.Add(input);
      }

      foreach (string word in words)
      {
        Console.WriteLine(word);
      }
    }
  }
}

using System;
using System.Collections.Generic;

namespace exercise_87
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        string[] parts = input.Split(" ");
        
        for (int i = 0; i < parts.Length; i++)
        {
          if (parts[i].Contains("av"))
          {
            Console.WriteLine(parts[i]);
          }
        }
      }

    }

  }

}


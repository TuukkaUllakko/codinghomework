using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
    {
      string input = Console.ReadLine();
      string[] pieces = input.Split(" ");

      for (int i = 0; i < pieces.Length; i++)
      {
        Console.WriteLine(pieces[i]);
      }

    }
  }
}


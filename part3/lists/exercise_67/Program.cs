using System;
using System.Collections.Generic;

namespace exercise_67
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          Console.WriteLine(list[0] + "\n" + list[list.Count - 1]);
          break;
        }
        list.Add(input);
      }

    }
  }
}

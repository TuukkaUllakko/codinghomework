using System;
using System.Collections.Generic;

namespace extra_09
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      List<string> list = new List<string>() {"This is a string", "This is magic", "THIS IS PATRICK!"};

      foreach (string word in list)
      {
        Console.WriteLine(word);
      }

      for (int i = 0; i < list.Count; i++)
      {
        Console.WriteLine(list[i]);
      }

      int endLoop = 0;
      while (endLoop < list.Count)
      {
        Console.WriteLine(list[endLoop]);
        endLoop++;
      }
    }
  }
}

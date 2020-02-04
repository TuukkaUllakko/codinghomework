using System;
using System.Collections.Generic;

namespace exercise_65
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      int values = 0;
      while (true)
      {
        string input = Console.ReadLine();
        
        if (input == "")
        {
          
          Console.WriteLine("In total: " + values);
          break;
        }
        list.Add(input);
        
        values++;
        
      }

    }
  }
}

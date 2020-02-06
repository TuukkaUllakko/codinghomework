using System;
using System.Collections.Generic;

namespace exercise_77
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> strings = new List<string>();
      strings.Add("First");
      strings.Add("Second");
      strings.Add("Third");
      strings.ForEach(Console.WriteLine); //Should print all 3
      RemoveLast(strings); //Removes third
      strings.ForEach(Console.WriteLine); //Should print remaining 2
      // You can try your method here if you want
    }
    public static void RemoveLast(List<string> strings) //Command RemoveLast(list) will remove the last object in the list.
    {
      strings.RemoveAt(strings.Count - 1); //-1 because indexes start from 0 and .Count starts from 1. Removes the last string.

    }

  }
}



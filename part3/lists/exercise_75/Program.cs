using System;
using System.Collections.Generic;

namespace exercise_75
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> numbers = new List<int>();
      numbers.Add(3);
      numbers.Add(7);
      numbers.Add(16);
      numbers.Add(4);
      numbers.Add(10);

      // Example method calls for testing your method.
      // List<int> numbers = new List<int>();
      // numbers.Add(5);

      Console.WriteLine("The numbers in the range [0, 5]");
      PrintNumbersInRange(numbers, 0, 5);

      Console.WriteLine("The numbers in the range [3, 10]");
      PrintNumbersInRange(numbers, 3, 10);
    }

    public static void PrintNumbersInRange(List<int> numbers, int lowerLimit, int upperLimit)
    {
      for (int i = 0; i < numbers.Count; i++)
      {
        int index = i;
        if ((lowerLimit <= numbers[index]) && upperLimit >= numbers[index])
        {
          Console.WriteLine(numbers[index]);

        }

      }

    }
    
  }
}


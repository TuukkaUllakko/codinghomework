using System;
using System.Collections.Generic;

namespace exercise_76
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> numbers = new List<int>();

      numbers.Add(4);
      numbers.Add(5);
      numbers.Add(6);
      Console.WriteLine(Sum(numbers));
      numbers.Add(10);
      Console.WriteLine(Sum(numbers));

    }
    public static int Sum(List<int> numbers)
    {
      int sum = 0;
      for (int i = 0; i < numbers.Count; i++)
      {
        sum = sum + numbers[i];

      }
      return sum;

    }

  }
}



using System;

namespace extra_03
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      int sum = 0;
      int total = 1;

      Console.WriteLine("How many numbers?");

      int times = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Give " + times + " numbers:");

      for (int i = 0; i < times; i++)
      {
        int number = Convert.ToInt32(Console.ReadLine());
        sum += number;
        total *= number;
      }

      Console.WriteLine("Their sum: " + sum +
      "\nTheir total: " + total +
      "\nTheir average: " + (double)sum / times);
    }
  }
}

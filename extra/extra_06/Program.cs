using System;

namespace extra_06
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      int input1 = Convert.ToInt32(Console.ReadLine());
      int input2 = Convert.ToInt32(Console.ReadLine());

      int sum = input1 + input2;
      if (sum < 0)
      {
        Console.WriteLine("0");
      }
      else
      {
      Console.WriteLine(Math.Sqrt(sum));
      }
    }
  }
}

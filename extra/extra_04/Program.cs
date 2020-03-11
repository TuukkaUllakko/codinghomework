using System;

namespace extra_04
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give your percent [0 - 100]:");

      int percent = Convert.ToInt32(Console.ReadLine());

      if (percent < 0)
      {
        Console.WriteLine("Impossible");
      }
      else if (percent >= 0 && percent <= 49)
      {
        Console.WriteLine("Fail");
      }
      else if (percent >= 50 && percent <= 59)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (percent >= 60 && percent <= 69)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (percent >= 70 && percent <= 79)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (percent >= 80 && percent <= 89)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (percent >= 90 && percent <= 100)
      {
        Console.WriteLine("Grade: 5");
      }
      else
      {
        Console.WriteLine("Outstanding!");
      }
    }
  }
}

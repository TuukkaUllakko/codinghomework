using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      //Starts the loop block
      while (true)
      {
        
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number != 0)
        {
          sum = sum + 1;

        }

        if (number == 0)
        {
          Console.WriteLine("Total amount of numbers: " + sum);
          break;

        }

      }

    }
  }
}

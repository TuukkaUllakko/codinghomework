using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      int number = 0;
      int input = Convert.ToInt32(Console.ReadLine());

      while (number <= input)
      {
        Console.WriteLine(number);
        number = number + 1;

      }

    }
  }
}

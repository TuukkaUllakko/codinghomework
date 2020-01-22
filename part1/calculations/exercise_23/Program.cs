using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      //Asks the user for the first integer
      Console.WriteLine("Give the first number!");

      //User input for the first integer
      double first = Convert.ToDouble(Console.ReadLine());

      //Asks the user for the second integer
      Console.WriteLine("Give the second number!");

      //User input for the second integer
      double second = Convert.ToDouble(Console.ReadLine());

      //All of the calculations for these two integers:
      Console.WriteLine(first + " + " + second + " = " + (first + second));
      Console.WriteLine(first + " - " + second + " = " + (first - second));
      Console.WriteLine(first + " * " + second + " = " + (first * second));
      Console.WriteLine(first + " / " + second + " = " + (first / second));

    }
  }
}

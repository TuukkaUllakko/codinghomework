using System;

namespace exercise_21
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

      //Calculates the average as a double
      Console.WriteLine("The average is " + (first + second) / 2);

    }
  }
}

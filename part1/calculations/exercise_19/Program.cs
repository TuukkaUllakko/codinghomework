using System;

namespace exercise_19
{
  class Program
  {
    public static void Main(string[] args)
    {

      //Asks the user for the first integer
      Console.WriteLine("Give the first number!");

      //User input for the first integer
      int first = Convert.ToInt32(Console.ReadLine());

      //Asks the user for the second integer
      Console.WriteLine("Give the second number!");

      //User input for the second integer
      int second = Convert.ToInt32(Console.ReadLine());

      //Prints the sum calculation and calculates the sum
      Console.WriteLine(first + " + " + second + " = " + (first + second));

    }
  }
}

using System;

namespace exercise_22
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

      //Asks the user for the third integer
      Console.WriteLine("Give the third number!");

      //User input for the third integer
      double third = Convert.ToDouble(Console.ReadLine());

      //Calculates the average of given integers (doubles) and shows the answer as a double
      Console.WriteLine("The average is " + (first + second + third) / 3);

    }
  }
}

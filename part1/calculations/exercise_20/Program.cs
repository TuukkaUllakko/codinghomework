using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

      //Asks the user for the first integer
      Console.WriteLine("Give the first number!");

      //User input for the first number
      int first = Convert.ToInt32(Console.ReadLine());

      //Asks the user for the second integer
      Console.WriteLine("Give the second number!");

      //User input for the second number
      int second = Convert.ToInt32(Console.ReadLine());

      //Multiplies the integers and shows the calculation
      Console.WriteLine(first + " * " + second + " = " + first * second);

    }
  }
}

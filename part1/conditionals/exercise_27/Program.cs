using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Asks the user for integer
      Console.WriteLine("Give a number:");
      //User input for the integer
      int number = Convert.ToInt32(Console.ReadLine());

      //If the number is greater than 0, print It is positive, if not, print It is not positive
      if (number > 0)
      {

        Console.WriteLine("It is positive");

      }
      else
      {

        Console.WriteLine("It is not positive");

      }

    }
  }
}

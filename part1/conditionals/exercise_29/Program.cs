using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Asks the user for first number
      Console.WriteLine("Give the first number!");
      //User input for the first number
      int first = Convert.ToInt32(Console.ReadLine());

      //Asks the user for second number
      Console.WriteLine("Give the second number!");
      //User input for the second number
      int second = Convert.ToInt32(Console.ReadLine());

      //Compare the numbers with "if", and print out the larger number. If equal, state it too
      if (first > second)
      {
        Console.WriteLine("The larger number is " + first + "!");

      }
      else if (first < second)
      {
        Console.WriteLine("The larger number is " + second + "!");

      }
      else
      {
        Console.WriteLine("They are equal!");

      }
    }
  }
}

using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Asks the user for integer
      Console.WriteLine("Give your age:");
      //User input for the integer
      int age = Convert.ToInt32(Console.ReadLine());

      //If age less than 1900, prints You're old
      if (age < 1900)
      {

        Console.WriteLine("You're old");

      }

    }
  }
}

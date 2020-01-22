using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Asks the user for integer
      Console.WriteLine("Give a number:");
      //User input for the integer
      int year = Convert.ToInt32(Console.ReadLine());

      //If the integer is exactly 1984, prints Orwell
      if (year == 1984)
      {

        Console.WriteLine("Orwell");

      }

    }
  }
}

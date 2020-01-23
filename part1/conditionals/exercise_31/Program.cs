using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Asks the user for a number
      Console.WriteLine("Give a number:");
      //User input for the number
      int number = Convert.ToInt32(Console.ReadLine());

      //Is the number dividable by 2 (Is the number even?)
      if ((number % 2) == 0)
      {
        Console.WriteLine("It is even.");
      }
      else
      {
        Console.WriteLine("It is odd.");
      }

    }
  }
}

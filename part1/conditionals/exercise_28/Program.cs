using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Asks the users age
      Console.WriteLine("How old are you?");
      //User input for age as an integer
      int age = Convert.ToInt32(Console.ReadLine());

      //If same or greater than 18, You're an adult!, else You're under age!
      if (age >= 18)
      {

        Console.WriteLine("You're an adult!");

      }
      else
      {

        Console.WriteLine("You're under age!");

      }
    }
  }
}

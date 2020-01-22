using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      //Asks the user for integer
      Console.WriteLine("Your speed:");
      //User input for the speed
      int speed = Convert.ToInt32(Console.ReadLine());

      //Conditional
      if (speed > 120)
      {
          //Prints Speeding! if integer over 120
          Console.WriteLine("Speeding!");

      }
      
    }
  }
}

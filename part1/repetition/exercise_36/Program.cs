using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Creates the "loop block"
      while (true)
      {
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        //Creates an if-block within the loop if 0, quit
        if (number == 0)
        {
          break;

        }

        //If negative, print "That is negative"
        else if (number < 0)
        {
          Console.WriteLine("That is negative");

        }
        else
        {
          Console.WriteLine(Math.Pow(number, 2)); //Math.Pow used for exponent, for raising to power!

        }


      }

    }
  }
}

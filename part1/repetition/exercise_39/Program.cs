using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      int soi = 0; //soi = sum of integers
      //Starts the while loop block
      while (true)
      {
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        //If blocks analyze the number
        if (number != 0)
        {
          soi = soi + number;
          
        }
        else
        {
          Console.WriteLine("Total sum of numbers: " + soi);
          break;
        }
      }
    }
  }
}

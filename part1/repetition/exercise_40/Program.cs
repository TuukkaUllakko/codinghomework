using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      int aon = 0; //amount of numbers
      int soi = 0; //sum of integers
      //Starts the while loop block
      while (true)
      {
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        //If comes in to analyze the answer and process it accordingly
        if (number != 0)
        {
          aon = aon + 1;
          soi = soi + number;

        }
        else
        {
          Console.WriteLine("Total sum of numbers: " + soi);
          Console.WriteLine("Total amount of numbers: " + aon);
          break;
        }
      }
    }
  }
}

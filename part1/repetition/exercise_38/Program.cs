using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      int smn = 0; //smn = sum of negatives
      //Starts the loop block
      while (true)
      {
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        //If blocks come in to analyze the answer
        if (number < 0)
        {
          smn = smn + 1;

        }
        else if (number == 0)
        {
          Console.WriteLine("Total amount of negative numbers: " + smn);
          break;

        }


      }

    }
  }
}

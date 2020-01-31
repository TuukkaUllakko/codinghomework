using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintUntilNumber(8);


    }

    // Write your method here:
    public static void PrintUntilNumber(int number)
    {
      int ladder = 1;
      
      while (true)
      {
        if (ladder <= number)
        {
          Console.WriteLine(ladder);
          ladder++;
          continue;

        }
        else
        {
          break;

        }
      }
      

    }

  }
}

using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      //User input for two integers seperately
      int first = Convert.ToInt32(Console.ReadLine());
      int second = Convert.ToInt32(Console.ReadLine());

      //Starts the if block
      
      if (first == second)
      {
        Console.WriteLine(first + " is equal to " + second + ".");

      }
      else if (first >= second)
      {
        Console.WriteLine(first + " is greater than " + second + ".");

      }
      else if (first <= second)
      {
        Console.WriteLine(first + " is less than " + second + ".");

      }

    }
  }
}

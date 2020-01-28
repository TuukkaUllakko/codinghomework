using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      //User input for the two integers
      int first = Convert.ToInt32(Console.ReadLine());
      int second = Convert.ToInt32(Console.ReadLine());

      //Sums the numbers together and prints out the square root of the result as a double
      double answer = Math.Sqrt(first + second);
      Console.WriteLine(answer);
    
    }
  }
}

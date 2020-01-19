using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      //Asks for the first number
      Console.WriteLine("Give the first number!");

      //User input for the first number
      int first = Convert.ToInt32(Console.ReadLine());

      //Asks for the second number
      Console.WriteLine("Give the second number!");

      //User input for the second number
      int second = Convert.ToInt32(Console.ReadLine());

      //The program sums the given numbers together
      int sum = first + second;
      Console.WriteLine(sum);

    }
  }
}

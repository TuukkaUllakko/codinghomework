using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

      //Asks the user for first integer
      Console.WriteLine("Give the first number!");
      
      //User input for the first integer
      int first = Convert.ToInt32(Console.ReadLine());

      //Asks the user for the second integer
      Console.WriteLine("Give the second number!");

      //User input for the second integer
      int second = Convert.ToInt32(Console.ReadLine());

      //Asks the user for the third integer
      Console.WriteLine("Give the third number!");

      //User input for the third integer
      int third = Convert.ToInt32(Console.ReadLine());

      //Sums the given integers together and tells it to the user
      Console.WriteLine("The sum is " + (first + second + third));

    }
  }
}

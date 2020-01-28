using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Reads the integer from user
      int number = Convert.ToInt32(Console.ReadLine());

      //Starts the if block
      if (number < 0)
      {
        Console.WriteLine(number * -1);

      }
      else
      {
        Console.WriteLine(number);
  
      }
      
    }
  }
}

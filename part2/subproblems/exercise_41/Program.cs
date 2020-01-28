using System;

namespace exercise_41
{
  class Program
  {
    public static void Main(string[] args)
    {

      //Asks the user for the integer
      int number = Convert.ToInt32(Console.ReadLine());
      
      
      //Prints it out in its second power
      Console.WriteLine(Math.Pow(number, 2));
    }
  }
}

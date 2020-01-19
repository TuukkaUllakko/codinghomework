using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      //Asks the user a question about the amount of days
      Console.WriteLine("How many days?");
      
      //User input to answer the question
      int days = Convert.ToInt32(Console.ReadLine());

      //The calculation where the program turns the amount of days into seconds
      Console.WriteLine(days * 86400);

    }
  }
}

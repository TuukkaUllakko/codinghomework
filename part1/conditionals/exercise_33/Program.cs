using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Asks the user for the first string
      Console.WriteLine("Give the first string:");
      //User input for the first string
      string first = Console.ReadLine();
      //Asks the user for the second string
      Console.WriteLine("Give the second string:");
      //User input for the second string
      string second = Console.ReadLine();

      //If same, print Echo!, if different, print Nope!
      if (first == second)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
        Console.WriteLine("Nope!");
      }

    }
  }
}

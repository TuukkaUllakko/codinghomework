using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Asks the user the beginning question
      Console.WriteLine("Speak, friend, and enter!");
      //User input for the word
      string answer = Console.ReadLine();
      

      if (answer == "Mellon")
      {
        Console.WriteLine("Welcome, friend!");
      }
      else
      {
        Console.WriteLine("They've got a cave troll!");
      }

    }
  }
}

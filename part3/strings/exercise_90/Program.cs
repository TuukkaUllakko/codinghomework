using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      int oldest = 0; //A variable we will need to determine the oldest of the given ages.
      while (true) //Starts a loop asking for questions.
      {
        string input = Console.ReadLine(); //User input
        if (input == "") //Stops the loop questioning from user if enter is simply pressed with no input.
        {
          break;
        }
        string[] parts = input.Split(","); //Splits the names from ages into separate pieces.
        int age = Convert.ToInt32(parts[1]);
        
        if (age > oldest)
        {
          oldest = age;
        }
      }
      Console.WriteLine("Age of the oldest: " + oldest); //Writes the oldest age given, which is saved as the variable in the beginning.


    }
  }
}




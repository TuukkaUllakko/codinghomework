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
        for (int i = 1; i < parts.Length; i++) //We know the first part will be a name at index 0. That's why the loop starts from 1 and not 0.
        {
          if (Convert.ToInt32(parts[i]) > oldest) //REMEMBER: YOU CAN CONVERT STRING -> INT LIKE THIS!
          {
            oldest = Convert.ToInt32(parts[i]); //If the new age is bigger than the current oldest age, the oldest age gets replaced by it with this if-statement.
          }
          i++; //This might not be necessary but also works. It makes the index grow by 2 instead of 1. Therefore, the indexes that will be checked are 1,3,5,etc.
        }      //Because we know the structure of the given names and ages has to be name,age, every other index will be an age (convertable to integer), starting from index 1.
      }
      Console.WriteLine("Age of the oldest: " + oldest); //Writes the oldest age given, which is saved as the variable in the beginning.


    }
  }
}




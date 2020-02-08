using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      string longname = "empty";
      int longest = 0;
      int highest = 0;
      while (true) //Starts a loop asking for questions.
      {
        string input = Console.ReadLine(); //User input
        if (input == "") //Stops the loop questioning from user if enter is simply pressed with no input.
        {
          break;
        }
        string[] parts = input.Split(","); //Splits the names from ages into separate pieces.
        int length = input.Length;
        int age = 2020 - Convert.ToInt32(parts[1]); //Turns the year of birth into integer and calculates the age. That's then the variable "age".
        if (length > longest) //Replaces the previous longest name length and the previous name if the new name length is longer.
        {
          longest = length;
          longname = parts[0];
        }
        if (age > highest) //Uses the age from "int age". If it's bigger than the previous highest age, the highets age gets replaced by it.
        {
          highest = age;
        }
      }
      Console.WriteLine("Longest name: " + longname); //Prints the result
      Console.WriteLine("Highest age: " + highest);   //Prints the result
    }
  }
}




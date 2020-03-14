using System;

namespace extra_11
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give a sentence:"); //Asks the user for a sentence

      string sentence = Console.ReadLine();  //User input for the sentence

      string[] pieces = sentence.Split(" "); //Cuts away the spaces in the sentence and puts the parts in an array called pieces

      foreach (string piece in pieces) //Prints out every piece in the pieces array
      {
        Console.WriteLine(piece);
      }
    }
  }
}

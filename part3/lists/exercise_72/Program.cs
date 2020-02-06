using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>(); //Creates the list.
      while (true) //Starts a loop that user inputs integers and stores them in said list. Stops if input is 9999.
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 9999)
        {
          break; //Ends loop.

        }
        list.Add(input); //Adds input to list.
      }
      //After the loop is complete, the program will pick the smallest given number/numbers from the list and also state what index they're found at.
      int smallest = list[0]; //States first that the first number on the list is the smallest.
      for (int i = 0; i < list.Count; i++) //Loop that checks numbers index at a time.
      {
       int number = list[i];
       if (smallest > number) //Number = Every number on the list at every index in order.
       {                      //If a number happens to be smaller than the "smallest" at the first index given in the beginning, it replaces "smallest" to the new smallest number.
         smallest = number;   //^^This loops until every number in the list has been checked by the loop. Then the loop ends.

       } 

      }
      Console.WriteLine("Smallest number: " + smallest); //After the loop ends, it tells the smallest number.
      for (int index = 0; index < list.Count; index++) //Starts the loop for finding the indexes for this/these smallest number(s).
      {
        if (list[index] == smallest) //If the number at this very index is equal to the smallest we determined earlier, it prints the sentence telling the index it's at.
        {
          Console.WriteLine("Found at index: " + index);
          //Repeat this until all numbers have been checked by the loop, then the program ends.
        }

      }

    }
  }
}

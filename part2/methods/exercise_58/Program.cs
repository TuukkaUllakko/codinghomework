using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    // Write your method here:

    public static int Smallest(int first, int second)
    {

      if (first > second)
      {
        return second;

      }

      else
      {
        return first;

      }


    }
    
  }
}

using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }

    // Write your method here:
    public static int Greatest(int first, int second, int third)
    {
      if (first > second && first > third)
      {
        return first;

      }
      
      else if (second > first && second > third)
      {
        return second;

      }

      else
      {
        return third;

      }

    }

  }
}

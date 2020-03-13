using System;

namespace extra_08
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      ChristmasTree(5);

    }
    public static void ChristmasTree(int height)
    {
      int amountSpaces = height - 1;
      int amountStars = 1;
      double stumpLocation = height - 2;

      for (int i = 0; i < height; i++)
      {

        for (int spaces = 0; spaces < amountSpaces; spaces++)
        {
          Console.Write(" ");
        }

        for (int stars = 0; stars < amountStars; stars++)
        {
          Console.Write("*");
        }
        amountSpaces--;
        amountStars = amountStars + 2;
        Console.WriteLine("");
      }

      for (int i = 0; i < stumpLocation; i++)
      {
        Console.Write(" ");
      }
      Console.WriteLine("***");

      for (int i = 0; i < stumpLocation; i++)
      {
        Console.Write(" ");
      }
      Console.WriteLine("***");
    }
  }
}

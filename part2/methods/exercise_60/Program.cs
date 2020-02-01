using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
      PrintTriangle(5);

    }


    public static void PrintStars(int number)
    {
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
      for (int stars = 1; stars <= number; stars++)
      {
        Console.Write("*");

      }
        Console.WriteLine("");
      
    }

    public static void PrintSquare(int size)
    {
    
      for (int square = 1; square <= size; square++)
      {
        PrintStars(size);
        
      }

    }

    public static void PrintRectangle(int width, int height)
    {
      for (int h = 1; h <= height; h++)
      PrintStars(width);

    }

    public static void PrintTriangle(int size)
    {
      for (int t = 1; t <= size; t++)
      {
        PrintStars(t);

      }

    }
  }
}

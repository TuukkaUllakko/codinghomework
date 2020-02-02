using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      ChristmasTree(4);

    }

    public static void PrintStars(int number)
    {
      for (int stars = 1; stars <= number; stars++)
      {
        Console.Write("*");

      }
      Console.WriteLine("");

    }

    public static void PrintSpaces(int number)
    {
      for (int space = 1; space <= number; space++)
      {
        Console.Write(" ");

      }

    }

    public static void PrintRightTriangle(int size)
    {
      for (int donezo = 1; donezo <= size; donezo++)
      {
        PrintSpaces(size - donezo);
        PrintStars(donezo);

      }

    }

    public static void ChristmasTree(int height)
    {
      int variable = 0;
      int add = 2;
      int addstump = height + add;
      while (variable < height)
      {
        
        variable++;
        
        if (variable == 2)
        {
          PrintSpaces(height - variable);
          variable++;
          PrintStars(variable);
          variable--;
          continue;

        }
        else if (variable >= 3)
        {
          
          PrintSpaces(height - variable);
          PrintStars(variable + add);
          add++;
          continue;

        }

          else
        {
          PrintSpaces(height - variable);
          PrintStars(variable);
          
        }
          

        

      }
        int end = 2;
        for (int stump = 1; stump <= end; stump++)
        {
          PrintSpaces(height - 2);
          PrintStars(3);

        }
    }
  }
}

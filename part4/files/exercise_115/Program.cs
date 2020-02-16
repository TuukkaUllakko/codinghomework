using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        String input = Console.ReadLine();
        if (input == "end")
        {
          break;
        }
        else
        {
          int number = Convert.ToInt32(input);
          Console.WriteLine(Math.Pow(number, 3));
        }
      }
    }
  }
}

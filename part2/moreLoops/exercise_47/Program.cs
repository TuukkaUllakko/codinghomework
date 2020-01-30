using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Where to?");
      int to = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int from = Convert.ToInt32(Console.ReadLine());

      for (int number = from; number <= to; number++)
      {
        Console.WriteLine(number);

      }
      
    }
  }
}

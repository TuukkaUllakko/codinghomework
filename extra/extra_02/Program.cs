using System;

namespace extra_02
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      int largest = Int32.MinValue;

      Console.WriteLine("Give three numbers:");

      for (int i = 0; i < 3; i++)
      {
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number > largest)
        {
          largest = number;
        }
      }

      Console.WriteLine("Largest: " + largest);
    }
  }
}

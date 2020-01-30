using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give numbers:"); 
      
      double sum = 0;
      double amount = 0;
      double odd = 0;
      double even = 0;

      
      
      while (true)
      {
        double number = Convert.ToDouble(Console.ReadLine());
        
        if (number != -1)
        {
          sum = sum + number;
          amount++;
          
          if (number % 2 == 0)
          {
            even++;

          }
          else
          {
            odd++;

          }

        }
        
        else if (number == -1)
        {
          Console.WriteLine("Thx! Bye!");
          Console.WriteLine("Sum: " + sum);
          Console.WriteLine("Numbers: " + amount);
          Console.WriteLine("Average: " + (sum / amount));
          Console.WriteLine("Even: " + even);
          Console.WriteLine("Odd: " + odd);
          break;
        }
        
        

      }
 
    }
  }
}

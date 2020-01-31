using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give numbers:"); 
      
      int sum = 0;
      int amount = 0;
      int odd = 0;
      int even = 0;

      
      
      while (true)
      {
        int number = Convert.ToInt32(Console.ReadLine());
        
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
          Console.WriteLine("Average: " + ((double)sum / amount));
          Console.WriteLine("Even: " + even);
          Console.WriteLine("Odd: " + odd);
          break;
        }
        
        

      }
 
    }
  }
}

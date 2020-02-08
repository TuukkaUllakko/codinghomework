using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter username:");
      string username = Console.ReadLine();
      Console.WriteLine("Enter password:");
      string password = Console.ReadLine();
      
      if (username == "alex")
      {
        if (password == "sunshine")
        {
          Console.WriteLine("You have successfully logged in!");
        }
        else
        {
          Console.WriteLine("Incorrect username or password!");
        }

      }
      
      else if (username == "emma")
      {
        if (password == "haskell")
        {
          Console.WriteLine("You have successfully logged in!");
        }
        else
        {
          Console.WriteLine("Incorrect username or password!");
        }
      }
      
      else
      {
        Console.WriteLine("Incorrect username or password!");
      }

    }
  }
}


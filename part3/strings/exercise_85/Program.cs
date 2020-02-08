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
      if (username == "alex")
      {
        Console.WriteLine("Enter password:");
        string passalex = Console.ReadLine();
        if (passalex == "sunshine")
        {
          Console.WriteLine("You have successfully logged in!");
        }
        else
        {
          Console.WriteLine("Incorrect username or password!");
        }

      }
      if (username == "emma")
      {
        Console.WriteLine("Enter password:");
        string passemma = Console.ReadLine();
        if (passemma == "haskell")
        {
          Console.WriteLine("You have successfully logged in!");
        }
        else
        {
          Console.WriteLine("Incorrect username or password!");
        }
      }

    }
  }
}


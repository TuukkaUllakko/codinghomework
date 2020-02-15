using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<TelevisionProgram> programs = new List<TelevisionProgram>(); 
      while (true)
      {
        Console.Write("Name: ");
        String name = Console.ReadLine();
        if (name == "")
        {
          break;
        }
        Console.Write("Duration: ");
        int duration = Convert.ToInt32(Console.ReadLine());
        programs.Add(new TelevisionProgram(name, duration));
      }
      Console.WriteLine();

      Console.Write("Program's maximum duration? ");
      int maxDuration = Convert.ToInt32(Console.ReadLine());

      foreach (TelevisionProgram program in programs)
      {
        if (program.duration <= maxDuration)
        {
        Console.WriteLine(program.name + ", " + program.duration + " minutes");
        }
      }


    }
  }
}





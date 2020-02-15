using System;
using System.Collections.Generic;

namespace exercise_111
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<PersonalInformation> list = new List<PersonalInformation>();

      while (true)
      {
        Console.WriteLine("First name:");
        String firstName = Console.ReadLine();
        if (firstName == "")
        {
          break;
        }
        Console.WriteLine("Last name:");
        String lastName = Console.ReadLine();
        Console.WriteLine("Identification number:");
        String identificationNumber = Console.ReadLine();
        list.Add(new PersonalInformation(firstName, lastName, identificationNumber));
      }

      Console.WriteLine();

      foreach (PersonalInformation info in list)
      {
        Console.WriteLine(info.firstName + " " + info.lastName);
      }
    }
  }
}





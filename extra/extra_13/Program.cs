using System;
using System.Collections.Generic;

namespace extra_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      List<Person> kids = new List<Person>();

      Person mike = new Person("Mike");
      mike.GrowOlder(2);
      kids.Add(mike);

      Person ada = new Person("Ada");
      ada.GrowOlder(5);
      kids.Add(ada);

      foreach (Person kid in kids)
      {
        Console.WriteLine(kid);
      }
    }
  }
}

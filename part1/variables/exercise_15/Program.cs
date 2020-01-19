using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give a string:");
      string string1 = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      int integer = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give a double:");
      double double1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Give a boolean:");
      bool boolean = System.Convert.ToBoolean(Console.ReadLine());
      Console.WriteLine("Your string: " + string1 + "\n" + "Your integer: " + integer + "\n" + "Your double: " + double1 + "\n" + "Your boolean: " + boolean);


    }
  }
}

using System;
namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter();
      
      Console.WriteLine(counter); //0 in the beginning

      counter.Decrease(5);

      Console.WriteLine(counter); //-5

      counter.Increase();

      Console.WriteLine(counter); //-4

      counter.Increase(14);

      Console.WriteLine(counter); //10
    }
  }
}

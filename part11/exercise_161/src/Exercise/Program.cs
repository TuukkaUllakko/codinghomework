namespace Exercise
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Die die = new Die(6);

        Console.WriteLine(die.ThrowDie());
    }
  }
}

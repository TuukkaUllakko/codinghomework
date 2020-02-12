using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account tuukkasAccount = new Account("Tuukka's account", 100.0);
      
      tuukkasAccount.Deposit(20);

      Console.WriteLine(tuukkasAccount.balance);

    }
  }
}




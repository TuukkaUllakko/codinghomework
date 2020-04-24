namespace Exercise
{
  using System;
  using System.Collections.Generic;

  public class LotteryRow
  {
    private List<int> numbers;

    public LotteryRow()
    {
      this.RandomizeNumbers();
    }

    public List<int> Numbers()
    {
      return this.numbers;
    }

    public bool ContainsNumber(int number)
    {
      // Tests whether the number is already among the randomized numbers
      if (this.numbers.Contains(number))
      {
        return true;
      }
      return false;
    }

    public void RandomizeNumbers()
    {
      // initialize the list for numbers
      this.numbers = new List<int>();
      // Implement the randomization of the numbers by using the method ContainsNumber() here
      Random lottery = new Random();
      for (int i = 0; i < 7; i++)
      {
        int randomNum = lottery.Next(1, 40);
        while (ContainsNumber(randomNum))
        {
          randomNum = lottery.Next(1, 40);
        }
        this.numbers.Add(randomNum);
      }
      this.numbers.Sort();
    }

  }
}
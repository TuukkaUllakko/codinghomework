using System;
using System.Collections.Generic;

namespace Exercise
{
  public class IOU
  {
    private Dictionary<string, int> debtBook; 
    public IOU()
    {
      this.debtBook = new Dictionary<string, int>();
    }
    public void ChangeDebt(string toWhom, int amount)
    {

      if (this.debtBook.ContainsKey(toWhom))
      {
        int newAmount = this.debtBook[toWhom] + amount;
        if (newAmount >= 0)
        {
          this.debtBook[toWhom] = newAmount;
        }
        else
        {
            this.debtBook[toWhom] = 0;
        }
      }
      else if (amount >= 0)
      {
        this.debtBook[toWhom] = amount;
      }
      else
      {
        this.debtBook[toWhom] = 0;
      }
    }

    public int HowMuchDoIOweTo(string toWhom)
    {

      if (this.debtBook.ContainsKey(toWhom))
      {
        return this.debtBook[toWhom];
      }
      else
      {
      return 0;
      }
    }
  }
}

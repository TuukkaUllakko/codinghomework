namespace Exercise
{
  using System;
  using System.Linq;
  using System.Collections.Generic;
  public class ChangeHistory
  {
    private List<int> history;

    public ChangeHistory()
    {
      this.history = new List<int>();
    }

    public void Add(int status)
    {
      this.history.Add(status);
    }

    public void Clear()
    {
      this.history.Clear();
    }

    public int MaxValue()
    {
      int largest = 0;
      if (this.history.Count > 0)
      {
        largest = this.history.Max();
      }
      return largest;
    }

    public int MinValue()
    {
      int smallest = 0;
      if (this.history.Count > 0)
      {
        smallest = this.history.Min();
      }
      return smallest;
    }

    public override string ToString()
    {
      int current = 0;
      foreach (var item in this.history)
      {
        current = item;
      }
      return "Current: " + current + " Min: " + MinValue() + " Max: " + MaxValue();
    }
  }
}

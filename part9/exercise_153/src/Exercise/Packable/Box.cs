using System.Collections.Generic;

namespace Exercise
{
  public class Box : IPackable
  {
    private int capacity;
    private List<IPackable> list;
    public Box(int i)
    {
      this.capacity = i;
      this.list = new List<IPackable>();
    }

    public void Add(IPackable item)
    {
      if (Weight() + item.Weight() <= this.capacity)
      {
        this.list.Add(item);
      }
    }

    public int Weight()
    {
      int sumOfWeight = 0;
      foreach (IPackable item in this.list)
      {
        sumOfWeight = sumOfWeight + item.Weight();
      }
      return sumOfWeight;
    }

    public override string ToString()
    {
      return this.list.Count + " items, total weight " + Weight() + " kg";
    }
  }
}
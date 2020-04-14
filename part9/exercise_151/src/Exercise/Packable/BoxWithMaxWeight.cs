namespace Exercise
{
  using System.Collections.Generic;
  using System.Linq;
  public class BoxWithMaxWeight : Box
  {
    private int capacity;
    private List<Item> list;
    public BoxWithMaxWeight(int capacity)
    {
      this.capacity = capacity;
      this.list = new List<Item>();
    }

    public override void Add(Item item)
    {
      if (item.weight <= this.capacity)
      {
        int sumOfListWeights = this.list.Sum(item => item.weight) + item.weight;
        if (sumOfListWeights <= this.capacity)
        {
          list.Add(item);
        }
      }
    }


    public override bool IsInBox(Item item)
    {
      if (this.list.Contains(item))
      {
        return true;
      }
      else
      {
      return false;
      }
    }
  }
}
namespace Exercise
{
  public class Furniture : IPackable
  {
    private string furniture;
    private string color;
    private int weight;
    public Furniture(string s, string s2, int i)
    {
      this.furniture = s;
      this.color = s2;
      this.weight = i;
    }

    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.color + " " + this.furniture + " - weight " + this.weight + " kg";
    }
  }
}
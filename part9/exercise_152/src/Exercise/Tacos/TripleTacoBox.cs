namespace Exercise
{
  public class TripleTacoBox : ITacoBox
  {
    private int tacoAmount;
    public TripleTacoBox()
    {
      this.tacoAmount = 3;
    }
    public int TacosRemaining()
    {
      return this.tacoAmount;
    }

    public void Eat()
    {
      if (this.tacoAmount > 0)
      {
        this.tacoAmount = this.tacoAmount - 1;
      }
    }
  }
}
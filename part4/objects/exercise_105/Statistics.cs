namespace exercise_105
{
  public class Statistics
  {
    public int count { get; set; }
    public int sum { get; set; }

    public Statistics()
    {
      // initialize the variables here
      this.count = count;
      this.sum = sum;
    }

    public void AddNumber(int number)
    {
      // write code here
      this.count = this.count + 1;
      this.sum = this.sum + number;
      
    }
  }
}
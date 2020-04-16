namespace Exercise
{
  public class Book : IPackable
  {
    private string author;
    private string name;
    private int publicationYear;
    private int weight;
    public Book(string s, string s2, int i)
    {
      this.author = s;
      this.name = s2;
      this.publicationYear = i;
      this.weight = 1;
    }

    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.author + ": " + this.name + " (" + this.publicationYear + ")";
    }
  }
}
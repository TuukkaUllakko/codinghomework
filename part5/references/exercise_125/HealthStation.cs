namespace exercise_125
{
  public class HealthStation
  {
    public int weighings { get; private set; }

    // Create a constructor here, if needed
    public HealthStation()
    {
      this.weighings = weighings;
    }

    public int Weigh(Person person)
    {
      // return the weight of the person passed as the parameter
      // incrase weighings
      weighings++;
      return person.weight;
    }

    public void Feed(Person person)
    {
      // Increse the weight of the person with one kilogram
      person.weight++;
    }
  }
}
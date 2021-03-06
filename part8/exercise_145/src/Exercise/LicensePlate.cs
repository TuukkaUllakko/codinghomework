namespace Exercise
{
  public class LicensePlate
  {
    public string liNumber { get; }
    private string country;

    public LicensePlate(string country, string liNumber)
    {
      this.liNumber = liNumber;
      this.country = country;
    }


    public override string ToString()
    {
      return country + " " + liNumber;
    }

    public override bool Equals(object compared)
    {
      if (this == compared)
      {
        return true;
      }
      if ((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }
      else
      {
        LicensePlate comparedLicense = (LicensePlate)compared;
        
        return this.liNumber == comparedLicense.liNumber && this.country == comparedLicense.country;
      }
    }

    public override int GetHashCode()
    {
      return this.liNumber.GetHashCode() + this.country.GetHashCode();
    }
  }
}
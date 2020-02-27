namespace exercise_128
{

  using System;
  public class Apartment
  {

    private int rooms;
    private int squares;
    private int pricePerSquare;

    public Apartment(int rooms, int squares, int pricePerSquare)
    {
      this.rooms = rooms;
      this.squares = squares;
      this.pricePerSquare = pricePerSquare;
    }

    public bool LargerThan(Apartment compared)
    {
      if (this.squares > compared.squares)
      {
        return true;
      }
      return false;
    }

    private int Price()
    {
      return this.pricePerSquare * this.squares;
    }

    public int PriceDifference(Apartment compared)
    {
      // Math.Abs returns the absolute value
      return Math.Abs(Price() - (compared.squares * compared.pricePerSquare));
    }

    public bool MoreExpensiveThan(Apartment compared)
    {
      if (Price() > compared.Price())
      {
        return true;
      }
      return false;
    }
  }

}

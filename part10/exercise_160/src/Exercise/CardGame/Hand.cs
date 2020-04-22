namespace Exercise
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  public class Hand : IComparable<Hand>
  {
    private List<Card> hand;
    
    public Hand()
    {
      this.hand = new List<Card>();
    }
    public void Add(Card card)
    {
      if (!this.hand.Contains(card))
      {
        this.hand.Add(card);
      }
    }

    public void Print()
    {
      this.hand.ForEach(Console.WriteLine);
    }

    public void Sort()
    {
      this.hand.Sort();
    }


    public int CompareTo(Hand hand)
    {
      int handValue = 0;
      foreach (Card card in this.hand)
      {
        handValue = handValue + card.value;
      }
      int comparedHandValue = 0;
      foreach (Card card in hand.hand)
      {
        comparedHandValue = comparedHandValue + card.value;
      }
      return handValue - comparedHandValue;
    }
  }
}
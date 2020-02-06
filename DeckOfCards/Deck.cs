using System;
using System.Collections.Generic;

namespace DeckOfCards
{
  class Deck
  {
    List<Card> cards = new List<Card>();
    List<string> suit = new List<string> { "Clubs", "Spades", "Hearts", "Diamonds" };
    List<string> stringVal = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

    public Deck()
    {

    }

    public Card Deal()
    {
      Card card = cards[0];
      cards.RemoveAt(0);
      return card;
    }

    public void Reset()
    {
      cards = new List<Card>();
      for (int i = 0; i < 3; i++)
      {
        for (int val = 0; val < 12; val++)
        {
          cards.Add(new Card(stringVal[val], suit[i], val + 1));
        }
      }
    }

    public void Shuffle()
    {
      List<Card> shuffledDeck = new List<Card>;
      Random rand = new Random();
      while (cards.Count > 0)
      {
        int randomIdx = rand.Next(0, cards.Count);
        shuffledDeck.Add(cards[randomIdx]);
        cards.RemoveAt(randomIdx);
      }
      cards = shuffledDeck;
    }
  }
}
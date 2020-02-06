using System;
using System.Collections.Generic;

namespace DeckOfCards
{
  class Player
  {
    string name;
    List<Card> hand;

    public Player(string Name)
    {
      name = Name;
    }

    public Card Draw(Deck deck)
    {
      hand.Add(deck.Deal());
      return hand[hand.Count];
    }
  }
}
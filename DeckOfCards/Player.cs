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

    public Card Discard(int cardIdx)
    {
      Card card = hand[cardIdx];
      hand.Remove(card);
      return card;
    }
  }
}
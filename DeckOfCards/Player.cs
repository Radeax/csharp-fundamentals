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
  }
}
using System;

namespace DeckOfCards
{
  class Card
  {
    string _stringVal;
    string _suit;
    int _val;

    public Card(string stringVal, string suit, int val)
    {
      _stringVal = stringVal;
      _suit = suit;
      _val = val;
    }
  }
}
using System;

namespace DeckOfCards
{
  class Card
  {
    public string _stringVal;
    public string _suit;
    int _val;

    public Card(string stringVal, string suit, int val)
    {
      _stringVal = stringVal;
      _suit = suit;
      _val = val;
    }
  }
}
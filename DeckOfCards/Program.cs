using System;

namespace DeckOfCards
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create Player
      Player myPlayer = new Player("Jo");

      // Create Deck
      Deck myDeck = new Deck();
      myDeck.Shuffle();

      // Draw 5 cards
      myPlayer.Draw(myDeck);
      myPlayer.Draw(myDeck);
      myPlayer.Draw(myDeck);
      myPlayer.Draw(myDeck);
      myPlayer.Draw(myDeck);

      // Display cards
      foreach (Card card in myPlayer.hand)
      {
        Console.WriteLine($"{card._stringVal} of {card._suit}");
      }

      Console.WriteLine("Choose card to discard: ");
      string discard = Console.ReadLine();
      int discardNum = Int32.Parse(discard);
      myPlayer.Discard(discardNum);

      // Display cards
      foreach (Card card in myPlayer.hand)
      {
        Console.WriteLine($"{card._stringVal} of {card._suit}");
      }

    }
  }
}

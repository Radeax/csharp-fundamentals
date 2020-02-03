using System;
using System.Collections.Generic;

namespace IronNinja
{
  class Program
  {
    static void Main(string[] args)
    {
      Buffet buffet = new Buffet();
      SweetTooth sweettooth = new SweetTooth();
      SpiceHound spicehound = new SpiceHound();

      while (!sweettooth.IsFull)
      {
        sweettooth.Consume(buffet.Serve());
      }
      int spiceCount = sweettooth.ConsumptionHistory.Count;

      while (!spicehound.IsFull)
      {
        spicehound.Consume(buffet.Serve());
      }
      spicehound.Consume(buffet.Serve());


      int sweetCount = spicehound.ConsumptionHistory.Count;

      if (spiceCount > sweetCount)
      {
        Console.WriteLine($"SweetTooth consumed the most, consuming {sweetCount} items!");
      }
      else
      {
        Console.WriteLine($"SpiceHound consumed the most, consuming {spiceCount} items!");
      }
    }
  }
}

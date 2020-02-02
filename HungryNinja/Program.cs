using System;
using System.Collections.Generic;

namespace HungryNinja
{
  class Program
  {
    static void Main(string[] args)
    {
      Ninja ninja = new Ninja();
      Buffet buffet = new Buffet();

      ninja.Eat(buffet.Serve());

      while (!ninja.isFull)
      {
        ninja.Eat(buffet.Serve());
      }
      ninja.Eat(buffet.Serve());
    }
  }
}

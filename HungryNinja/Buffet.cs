using System;
using System.Collections.Generic;

namespace HungryNinja
{
  class Buffet
  {
    public List<IConsumable> Menu;

    public Buffet()
    {
      Menu = new List<IConsumable>()
      {
          new Food("Pizza", 200, false, false),
          new Food("Fried Rice", 228, false, false),
          new Food("Mango", 201, false, true),
          new Food("Buffalo Wings", 143, true, true),
          new Food("Jalapeno", 26, true, false),
          new Food("Ice Cream", 137, false, true),
          new Food("Ribs", 299, false, false),
          new Drink("Water", 0, false, false),
          new Drink("Coke", 140, false, true),
          new Drink("Tea", 2, false, false),
          new Drink("Moscow Mule", 182, true, false)
      };
    }

    public IConsumable Serve()
    {
      Random rand = new Random();
      return Menu[rand.Next(0, Menu.Count)];
    }
  }
}
using System;
using System.Collections.Generic;

namespace HungryNinja
{
  class Buffet
  {
    public List<Food> Menu;

    public Buffet()
    {
      Menu = new List<Food>()
      {
          new Food("Pizza", 200, false, false),
          new Food("Fried Rice", 228, false, false),
          new Food("Mango", 201, false, true),
          new Food("Buffalo Wings", 143, true, true),
          new Food("Jalapeno", 26, true, false),
          new Food("Ice Cream", 137, false, true),
          new Food("Ribs", 299, false, false),
      };
    }

    public Food Serve()
    {
      Random rand = new Random();
      return Menu[rand.Next(0, Menu.Count)];
    }
  }
}
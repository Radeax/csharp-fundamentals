using System;
using System.Collections.Generic;

namespace HungryNinja
{
  class Ninja
  {
    private int calorieIntake;
    public List<Food> FoodHistory;

    public Ninja()
    {
      FoodHistory = new List<Food>();
    }

    public bool isFull
    {
      get { return calorieIntake > 1200; }
    }

    public void Eat(Food item)
    {
      if (!isFull)
      {
        calorieIntake += item.Calories;
        FoodHistory.Add(item);
        Console.WriteLine($"Ninja ate {item.Name} | Spicy: {item.isSpicy} | Sweet: {item.isSweet}");
      }
      else
      {
        Console.WriteLine("Ninja is full and cannot eat anymore food.");
      }
    }
  }
}
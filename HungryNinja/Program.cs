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

  class Food
  {
    public string Name;
    public int Calories;
    public bool isSpicy;
    public bool isSweet;

    public Food(string name, int cal, bool spicy, bool sweet)
    {
      Name = name;
      Calories = cal;
      isSpicy = spicy;
      isSweet = sweet;
    }
  }

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

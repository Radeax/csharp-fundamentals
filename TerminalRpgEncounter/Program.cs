using System;
using System.Collections.Generic;

namespace TerminalRpgEncounter
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

  class Human
  {
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    protected int health;

    public int Health
    {
      get { return health; }
    }

    public Human(string name)
    {
      Name = name;
      Strength = 3;
      Intelligence = 3;
      Dexterity = 3;
      health = 100;
    }

    public Human(string name, int strength, int intel, int dex, int hp)
    {
      Name = name;
      Strength = strength;
      Intelligence = intel;
      Dexterity = dex;
      health = hp;
    }

    public virtual int Attack(Human target)
    {
      int damage = Strength * 5;
      target.health -= damage;
      return target.health;
    }
  }

  class Ninja : Human
  {
    public Ninja(string name) : base(name)
    {
      Dexterity = 175;
    }
  }

  class Wizard : Human
  {
    public Wizard(string name) : base(name)
    {
      health = 50;
      Intelligence = 25;
    }

    public override int Attack(Human target)
    {
      int damage = Intelligence * 5;
      target.health -= damage;


    }
  }

  class Samurai : Human
  {
    public Samurai(string name) : base(name)
    {
      health = 200;
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

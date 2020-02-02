using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai
{
  class Program
  {
    static void Main(string[] args)
    {
      Human human = new Human("human");
      Ninja ninja = new Ninja("ninja");
      Wizard wizard = new Wizard("wizard");
      Samurai samurai = new Samurai("samurai");

      Console.WriteLine(ninja.Attack(wizard));
      Console.WriteLine(wizard.Attack(samurai));
      Console.WriteLine(samurai.Attack(ninja));
    }
  }

  class Human
  {
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;

    public int Health
    {
      get { return health; }
      set { health = value; }
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

    public override int Attack(Human target)
    {
      Random rand = new Random();

      int damage = Dexterity * 5;
      target.Health -= damage;

      if (rand.Next(1, 11) <= 2)
      {
        target.Health -= 10;
      }
      return target.Health;
    }

    public void Steal(Human target)
    {
      target.Health -= 5;
      health += 5;
    }
  }

  class Wizard : Human
  {
    public Wizard(string name) : base(name)
    {
      Health = 50;
      Intelligence = 25;
    }

    public override int Attack(Human target)
    {
      int damage = Intelligence * 5;
      target.Health -= damage;
      Health += damage;
      return target.Health;
    }

    public void Health(Human target)
    {
      target.Health += 10 * Intelligence;
    }
  }

  class Samurai : Human
  {
    public Samurai(string name) : base(name)
    {
      Health = 200;
    }

    public override int Attack(Human target)
    {
      base.Attack(target);
      if (target.Health < 50)
      {
        target.Health = 0;
      }
      return target.Health;
    }

    public void Meditate()
    {
      health = 200;
    }
  }
}
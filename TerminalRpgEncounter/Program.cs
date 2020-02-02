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
}

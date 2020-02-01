using System;

namespace TerminalRpgEncounter
{
  class Program
  {
    static void Main(string[] args)
    {
      Human ninja1 = new Human("ninja1");
      Human ninja2 = new Human("ninja2");

      Console.WriteLine($"ninja2 has {ninja2.Health} HP");
      ninja1.Attack(ninja2);
      Console.WriteLine("ninja1 attacks ninja2!");
      Console.WriteLine($"ninja2 now has {ninja2.Health} HP");
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

    public int Attack(Human target)
    {
      target.health -= Strength * 5;
      return target.health;
    }
  }
}

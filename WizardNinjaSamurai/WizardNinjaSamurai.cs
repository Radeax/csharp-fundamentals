using System;

namespace WizardNinjaSamurai
{
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
      health = 50;
      Intelligence = 25;
    }

    public override int Attack(Human target)
    {
      int damage = Intelligence * 5;
      target.Health -= damage;
      health += damage;
      return target.Health;
    }

    public void Heal(Human target)
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
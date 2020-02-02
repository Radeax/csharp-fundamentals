using System;

namespace HungryNinja
{
  class SpiceHound : Ninja
  {
    public override bool IsFull
    {
      get { return calorieIntake >= 1200; }
    }

    public override void Consume(IConsumable item)
    {
      if (IsFull)
      {
        Console.WriteLine("SpiceHound is full and cannot eat anymore!");
      }
      else
      {
        // Add to total calorie intake
        calorieIntake += item.Calories;
        if (item.IsSpicy == true) { calorieIntake -= 5; }

        // Add to consumption history
        ConsumptionHistory.Add(item);

        Console.WriteLine(item.GetInfo());
      }
    }
  }
}
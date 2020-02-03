using System;

namespace IronNinja
{
  class SweetTooth : Ninja
  {
    public override bool IsFull
    {
      get { return calorieIntake >= 1500; }
    }

    public override void Consume(IConsumable item)
    {
      if (IsFull)
      {
        Console.WriteLine("SweetTooth is full and cannot eat anymore!");
      }
      else
      {
        // Add to total calorie intake
        calorieIntake += item.Calories;
        if (item.IsSweet == true) { calorieIntake += 10; }

        // Add to consumption history
        ConsumptionHistory.Add(item);

        Console.WriteLine(item.GetInfo());
      }
    }
  }
}
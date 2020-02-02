namespace HungryNinja
{
  interface IConsumable
  {
    string Name { get; set; }
    int Calories { get; set; }
    bool isSpicy { get; set; }
    bool isSweet { get; set; }
    string GetInfo();
  }
}
namespace HungryNinja
{
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
}
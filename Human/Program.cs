using System;


namespace Human
{
  class Program
  {
    static void Main(string[] args)
    {
      Human human1 = new Human("human1");
      Human human2 = new Human("human2");

      Console.WriteLine(human1.Attack(human2));
      Console.WriteLine(human2.Attack(human1));
      Console.WriteLine(human1.Attack(human2));
    }
  }
}
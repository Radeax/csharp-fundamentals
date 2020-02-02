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
}
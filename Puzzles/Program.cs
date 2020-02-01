using System;

namespace Puzzles
{
  class Program
  {
    static void Main(string[] args)
    {
      RandomArray();
      Console.WriteLine(TossMultipleCoins(4));
    }

    public static void RandomArray()
    {
      Random rand = new Random();
      int min = new int();
      int max = new int();
      int sum = 0;

      int[] numArray = new int[10];

      // Place 10 random integer values between 5-25 into the array
      for (int i = 0; i < 10; i++)
      {
        numArray[i] = rand.Next(5, 25);
      }

      min = numArray[0];
      max = numArray[0];

      // Find the min, max, and sum
      foreach (int n in numArray)
      {
        if (min > n)
        {
          min = n;
        }
        if (max < n)
        {
          max = n;
        }
        sum += n;
      }

      // Print the min, max, and sum of array
      Console.WriteLine($"Min: {min}");
      Console.WriteLine($"Max: {max}");
      Console.WriteLine($"Sum: {sum}");
    }

    public static string TossCoin()
    {
      string coin = "";
      Random rand = new Random();

      Console.Write("Tossing a coin! - ");

      // Check 'Heads' or 'Tails'
      if (rand.Next(1, 3) == 1)
      {
        coin = "Heads";
      }
      else
      {
        coin = "Tails";
      }

      // Print and return result
      Console.WriteLine(coin);
      return coin;
    }

    public static double TossMultipleCoins(int num)
    {
      int heads = 0;

      // Toss coins n times
      for (int n = num; n > 0; n--)
      {
        if (TossCoin() == "Heads")
        {
          heads++;
        }
      }

      // Find and return heads ratio
      double headRatio = (double)heads / (double)num;
      return headRatio;
    }
  }
}

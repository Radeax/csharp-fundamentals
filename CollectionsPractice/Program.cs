using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
  class Program
  {
    static void Main(string[] args)
    {
      // THREE BASIC ARRAYS
      // Create an array to hold integer values 0 through 9
      // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
      // Create an array of length 10 that alternates between true and false values, starting with true

      int[] numArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      string[] strArray = { "Tim", "Martin", "Nikki", "Sara" };
      bool[] boolArray = new bool[10];
      for (int i = 0; i < boolArray.Length; i++)
      {
        if (i % 2 == 0)
        {
          boolArray[i] = true;
        }
        else
        {
          boolArray[i] = false;
        }
      }
      // foreach (var i in boolArray)
      // {
      //   Console.WriteLine(i);
      // }

      // LIST OF FLAVORS
      // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
      // Output the length of this list after building it
      // Output the third flavor in the list, then remove this value
      // Output the new length of the list (It should just be one fewer!)

      List<string> flavors = new List<string>();
      flavors.Add("Chocolate");
      flavors.Add("Vanilla");
      flavors.Add("Strawberry");
      flavors.Add("Cookies & Cream");
      flavors.Add("Hazelnut");

      Console.WriteLine(flavors.Count);
      Console.WriteLine(flavors[2]);
      flavors.RemoveAt(2);
      foreach (string flavor in flavors)
      {
        Console.WriteLine($"{flavor}");
      }

      // USER INFO DICTIONARY
      // Create a dictionary that will store both string keys as well as string values
      // Add key/value pairs to this dictionary where:
      // each key is a name from your names array
      // each value is a randomly select a flavor from your flavors list.
      // Loop through the dictionary and print out each user's name and their associated ice cream flavor
      Random rand = new Random();
      Dictionary<string, string> favoriteFlavors = new Dictionary<string, string>();
      foreach (var name in strArray)
      {
        favoriteFlavors.Add($"{name}", flavors[rand.Next(0, flavors.Count)]);
      }
      foreach (var entry in favoriteFlavors)
      {
        Console.WriteLine(entry.Key + " - " + entry.Value);
      }
    }
  }
}

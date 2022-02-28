using System;
using System.Collections.Generic;
using System.Linq;

class Challenge
{
  public static void Main(string[] args)
  {
    int numberOftests = int.Parse(Console.ReadLine());
  
    for (int i = 0; i < numberOftests; i++) {
      List<string> shoppinglist = new List<String>(Console.ReadLine().Split(' '));
      List<string> listWithoutDuplicates = shoppinglist.Distinct().ToList();

      listWithoutDuplicates.Sort();
  
      foreach (string item in listWithoutDuplicates) {
        Console.Write($"{item} ");
      }
      
      Console.WriteLine(" ");
    }
  }
}

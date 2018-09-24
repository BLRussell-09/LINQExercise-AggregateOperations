using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateOps
{
  class Program
  {
    static void Main(string[] args)
    {
      // Output how many numbers are in this list
      List<int> numbers = new List<int>()
      {
          15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      };

      var numberCounter = (from number in numbers
                          select number).Count();

      Console.WriteLine(numberCounter);

      Console.WriteLine(numbers.Count());

      // How much money have we made?
      List<double> purchases = new List<double>()
      {
          2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
      };

      var numberSum = (from purchase in purchases
                      select purchase).Sum();

      Console.WriteLine(numberSum);

      Console.WriteLine(purchases.Sum());

      // What is our most expensive product?
      List<double> prices = new List<double>()
      {
          879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
      };

      var maxPrice = (from price in prices
                     select price).Max();

      Console.WriteLine(maxPrice);

      Console.WriteLine(prices.Max());

      Console.ReadLine();
    }
  }
}

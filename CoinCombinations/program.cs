using System;

namespace Currency
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter an amount between 1-99 cents!");
      int cents = int.Parse(Console.ReadLine());
    }
  }
}
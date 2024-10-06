using System;

namespace ConsoleBackThen
{
  internal class Program
  {
    static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("console back then");
      Console.WriteLine("a long time ago I discovered first computer with this green color");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("And then it was this yellowish color");
      Console.WriteLine("press any key to exit:");
      Console.ReadKey();
    }
  }
}

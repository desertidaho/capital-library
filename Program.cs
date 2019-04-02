using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Welcome to Capital Library.");
      App app = new App();
      app.Run();
    }
  }
}

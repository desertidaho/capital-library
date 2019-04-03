using System;
using System.Collections.Generic;
using console_library.Interfaces;
using console_library.Models;

namespace console_library
{
  class App
  {
    public void Run()
    {
      bool inLibrary = true;
      while (inLibrary)
      {
        Console.Clear();
        Console.WriteLine("Press (B)ooks, (E)lectronics, (M)agazines, (N)ewspapers, or (V)ideos.");
        string response = Console.ReadLine().ToLower();
        switch (response)
        {
          case "b":
            BookService bs = new BookService();
            bs.Run();
            break;
          case "e":
            // BookService bs = new BookService();
            // bs.Run();
            break;
          case "m":
            // BookService bs = new BookService();
            // bs.Run();
            break;
          case "n":
            // BookService bs = new BookService();
            // bs.Run();
            break;
          case "v":
            // BookService bs = new BookService();
            // bs.Run();
            break;
          default:
            Console.WriteLine("Invalid Selection, try again.");
            break;
        }


      }
    }


    public App()
    {

    }
  }
}
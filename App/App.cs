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
      Console.WriteLine("Press (B)ooks, (E)lectronics, (M)agazines, (N)ewspapers, or (V)ideos.");
      string response = Console.ReadLine().ToLower();
      bool inLibrary = true;
      Library myLibrary = new Library("Boise", "Capital Library");
      while (inLibrary)
      {
        myLibrary.PrintBooks(myLibrary.Books);
        Console.WriteLine(@"
Select a number to checkout book. Press Q to quit, or R to return a book.");
        string selection = Console.ReadLine().ToLower();
        Console.Clear();
        if (selection == "q")
        {
          Console.WriteLine("Sorry to see you go. Goodbye.");
          return;
        }
        else if (selection == "r")
        {
          Console.WriteLine(@"Here are the books you have checked out:");
          myLibrary.PrintBooks(myLibrary.CheckedOut);
          Console.WriteLine(@"
Select a book to return.");
          string bookToReturn = Console.ReadLine().ToLower();
          myLibrary.CheckIn(bookToReturn);
        }
        else
        {
          myLibrary.Checkout(selection);
        }
      }
    }


    public App()
    {

    }
  }
}
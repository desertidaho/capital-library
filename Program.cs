using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      bool inLibrary = true;
      Library myLibrary = new Library("Boise", "Capital Library");
      Console.Clear();
      Console.WriteLine(@"Welcome to Capital Library.
      
Available Books:");
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
  }
}

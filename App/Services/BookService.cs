using System;
using System.Collections.Generic;

namespace console_library.Models
{
  class BookService
  {
    Library myLibrary = new Library("Boise", "Capital Library");

    public void Run()
    {
      bool inBookService = true;
      while (inBookService)
      {

        Console.Clear();
        Console.WriteLine("Here are all of the books in the library:");
        Console.WriteLine(" ");
        myLibrary.PrintBooks(myLibrary.Books);
        Console.WriteLine(@"
Select a number to checkout book. Press Q to quit, or R to return a book.");
        string selection = Console.ReadLine().ToLower();
        if (selection == "q")
        {
          Console.Clear();
          Console.WriteLine("Sorry to see you go. Goodbye.");
          return;
        }
        else if (selection == "r")
        {
          Console.Clear();
          Console.WriteLine(@"Here are the books you have checked out:");
          myLibrary.PrintBooks(myLibrary.CheckedOut);
          Console.WriteLine(@"
Select a book to return.");
          string bookToReturn = Console.ReadLine().ToLower();
          myLibrary.CheckIn(bookToReturn);
        }
        else
        {
          inBookService = myLibrary.Checkout(selection);
        }
      }
    }




  }
}
using System;
using System.Collections.Generic;

namespace console_library.Models
{

  public class Library
  {
    public string Location { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; private set; }
    public List<Book> CheckedOut { get; private set; }

    public void PrintBooks(List<Book> books)
    {
      for (int i = 0; i < books.Count; i++)
      {
        Console.WriteLine(value: $"{i + 1}. {books[i].Title} by {books[i].Author}");
      }
    }

    public void AddBook(Book book)
    {
      Books.Add(book);
    }

    public void Checkout(string selection)
    {
      Book selectedBook = ValidateBook(selection, Books);

      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine(@"Invalid Selection
                        ");
        return;
      }
      else
      {
        selectedBook.Available = false;
        CheckedOut.Add(selectedBook);
        Books.Remove(selectedBook);
        Console.WriteLine($"Congrats, you checked out {selectedBook.Title} by {selectedBook.Author}.");
        Console.WriteLine(@"
Here are the remaining books in the library:");
      }
    }

    public void CheckIn(string selection)
    {
      Book selectedBook = ValidateBook(selection, CheckedOut);
      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine(@"Invalid Selection
                        ");
        return;
      }
      else
      {
        selectedBook.Available = true;
        Books.Add(selectedBook);
        CheckedOut.Remove(selectedBook);
        Console.Clear();
        Console.WriteLine($"Congrats, you returned {selectedBook.Title} by {selectedBook.Author}.");
        Console.WriteLine(@"
Available books:");
      }
    }

    private Book ValidateBook(string selection, List<Book> bookList)
    {
      int bookIndex;
      bool valid = Int32.TryParse(selection, out bookIndex);
      if (!valid || bookIndex < 0 || bookIndex > bookList.Count)
      {
        return null;
      };
      return bookList[bookIndex - 1];
    }

    public Library(string location, string name)
    {
      Location = location;
      Name = name;
      Books = new List<Book>()
      {
      new Book("Where the Sidewalk Ends", "Shel Silverstein"),
      new Book("Things Fall Apart", "Chinua Achebe"),
      new Book("A New Earth", "Eckhart Tolle"),
      new Book("Ficciones", "Jorge Luis Borges"),
    };
      CheckedOut = new List<Book>();
    }
  }
}
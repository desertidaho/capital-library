using System;
using System.Collections.Generic;

namespace console_library.Models
{

  public class Library
  {
    public string Location { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; private set; }
    public List<Electronic> Electronics { get; private set; }
    public List<Magazine> Magazines { get; private set; }
    public List<Newspaper> Newspapers { get; private set; }
    public List<Video> Videos { get; private set; }
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
      new Book("Where the Sidewalk Ends", "April 1974", "Shel Silverstein"),
      new Book("Things Fall Apart", "December 1958", "Chinua Achebe"),
      new Book("A New Earth", "October 2006", "Eckhart Tolle"),
      new Book("Ficciones", "September 1944", "Jorge Luis Borges"),
    };

      Electronics = new List<Electronic>()
      {
      new Electronic("Nintendo", "2016"),
      new Electronic("Xbox", "2017"),
      new Electronic("PlayStation", "2017"),
    };

      Magazines = new List<Magazine>()
      {
      new Magazine("Economist", "March 2019"),
      new Magazine("Dwell", "March 2019"),
      new Magazine("New Yorker", "February 2019"),
    };

      Newspapers = new List<Newspaper>()
      {
      new Newspaper("Times News", "Today"),
      new Newspaper("Boise Weekly", "April 2019"),
      new Newspaper("Idaho Statesman", "April 2019"),
    };

      Videos = new List<Video>()
      {
      new Video("National Lampoons Christmas Vacation", "December 1980"),
      new Video("Hunt For Red October", "October 1984"),
      new Video("Shawshank Redemption", "June 1994"),
    };

      CheckedOut = new List<Book>();
    }
  }
}
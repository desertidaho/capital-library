namespace console_library.Models
{
  class Book : Publication
  {
    public string Author { get; set; }

    public Book(string title, string publicationDate, string author, bool available) : base(title, publicationDate, available)
    {
      Author = author;
    }
  }
}
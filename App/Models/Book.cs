using console_library.Interfaces;

namespace console_library.Models
{
  class Book : Publication, ICheckoutable
  {
    public string Author { get; set; }
    public string DateCheckedOut { get; set; }
    public string DateDue { get; set; }

    public Book(string title, string publicationDate, string author) : base(title, publicationDate)
    {
      Author = author;
    }
  }
}
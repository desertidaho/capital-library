using console_library.Interfaces;

namespace console_library.Models
{
  class Newspaper : Publication, ICheckoutable
  {
    public string DateCheckedOut { get; set; }
    public string DateDue { get; set; }



    public Newspaper(string title, string publicationDate) : base(title, publicationDate)
    {

    }

  }
}
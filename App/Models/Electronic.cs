using console_library.Interfaces;

namespace console_library.Models
{
  class Electronic : Publication, ICheckoutable
  {
    public string DateCheckedOut { get; set; }
    public string DateDue { get; set; }



    public Electronic(string title, string publicationDate) : base(title, publicationDate)
    {

    }

  }
}
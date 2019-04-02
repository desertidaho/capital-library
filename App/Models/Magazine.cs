using console_library.Interfaces;

namespace console_library.Models
{
  class Magazine : Publication, ICheckoutable
  {
    public string DateCheckedOut { get; set; }
    public string DateDue { get; set; }

    public Magazine(string title, string publicationDate) : base(title, publicationDate)
    {

    }
  }
}
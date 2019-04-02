using console_library.Interfaces;

namespace console_library.Models
{
  class Video : Publication, ICheckoutable
  {
    public string DateCheckedOut { get; set; }
    public string DateDue { get; set; }



    public Video(string title, string publicationDate) : base(title, publicationDate)
    {

    }

  }
}
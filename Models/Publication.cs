namespace console_library.Models
{
  abstract class Publication
  {
    public string Title { get; set; }
    public bool Available { get; set; }
    public string PublicationDate { get; set; }

    public Publication(string title, string publicationDate, bool available)
    {
      Title = title;
      Available = true;
      PublicationDate = publicationDate;
    }
  }
}
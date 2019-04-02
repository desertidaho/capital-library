namespace console_library.Interfaces
{
  interface ICheckoutable
  {
    string DateCheckedOut { get; set; }
    string DateDue { get; set; }


  }
}
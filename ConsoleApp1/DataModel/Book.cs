namespace ConsoleApp1.DataModel;

public class Book: IBook
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}
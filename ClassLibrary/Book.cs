namespace ClassLibrary;
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public bool IsAvailable { get; set; }

    public Book (string title, string author, int year, bool isAvailable)
    {
        this.Title = title;
        this.Author = author;
        this.Year = year;
        this.IsAvailable = isAvailable;
    }
}

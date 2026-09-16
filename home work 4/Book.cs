class Book
{
    public string Title;
    public string Author;
    public int Year;

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public void GetInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Year: " + Year);
    }

    public bool IsPublishedRecently()
    {
        if (Year >= 2020)
        {
            return true;
        }

        return false;
    }
}
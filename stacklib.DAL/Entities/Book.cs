namespace stacklib.DAL.Entities;

public class Book
{
    public int BookId { get; set; }
    public string BookTitle { get; set; } = string.Empty;
    public string BookAuthor { get; set; } = string.Empty;
    public string BookISBN { get; set; } = string.Empty;
    public string BookPublishingHouse { get; set; } = string.Empty;
    public string BookLanguage { get; set; } = string.Empty;
    public DateTime BookPublicationDate { get; set; }
    public int BookPageCount { get; set; }

    //TO ADD
    //book cover image
}

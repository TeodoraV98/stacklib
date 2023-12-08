using stacklib.DAL.Entities;

namespace stacklib.BLL.DTOs;

public class BookDTO
{
    public int BookId { get; set; }
    public string BookTitle { get; set; } = string.Empty;
    public string BookAuthor { get; set; } = string.Empty;
    public string BookISBN { get; set; } = string.Empty;
    public string BookPublishingHouse { get; set; } = string.Empty;
    public string BookLanguage { get; set; } = string.Empty;
    public DateTime BookPublicationDate { get; set; }
    public int BookPageCount { get; set; }

    public static BookDTO FromBook(Book book)
    {
        return new BookDTO
        {
            BookId = book.BookId,
            BookTitle = book.BookTitle,
            BookAuthor = book.BookAuthor,
            BookISBN = book.BookISBN,
            BookPublishingHouse = book.BookPublishingHouse,
            BookLanguage = book.BookLanguage,
            BookPublicationDate = book.BookPublicationDate,
            BookPageCount = book.BookPageCount
        };
    }
}

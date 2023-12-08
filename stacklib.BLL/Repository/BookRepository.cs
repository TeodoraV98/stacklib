using Microsoft.EntityFrameworkCore;
using stacklib.DAL.AppDbContext;
using stacklib.DAL.Entities;

namespace stacklib.BLL.Repository;

public class BookRepository : IBookRepository
{
    private readonly StacklibDbContext _stacklibDbContext;

    public BookRepository(StacklibDbContext stacklibDbContext)
    {
        _stacklibDbContext = stacklibDbContext;
    }

    public IEnumerable<Book> GetAllBooks()
    {
        return _stacklibDbContext.Books.ToList();
    }

    public Book GetBookById(int id)
    {
        return _stacklibDbContext.Books.FirstOrDefault(b => b.BookId == id);
    }

    public void AddBook(Book book)
    {
        _stacklibDbContext.Books.Add(book);
        _stacklibDbContext.SaveChanges();
    }

    public void UpdateBook(int id, Book updatedBook)
    {
        var book = _stacklibDbContext.Books.FirstOrDefault(b => b.BookId == id);
        if (book != null)
        {
            book.BookTitle = updatedBook.BookTitle;
            book.BookAuthor = updatedBook.BookAuthor;
            book.BookISBN = updatedBook.BookISBN;
            book.BookPublishingHouse = updatedBook.BookPublishingHouse;
            book.BookLanguage = updatedBook.BookLanguage;
            book.BookPublicationDate = updatedBook.BookPublicationDate;
            book.BookPageCount = updatedBook.BookPageCount;

            _stacklibDbContext.SaveChanges();
        }
    }

    public void DeleteBook(int id)
    {
        var book = _stacklibDbContext.Books.FirstOrDefault(b => b.BookId == id);
        if (book != null)
        {
            _stacklibDbContext.Books.Remove(book);
            _stacklibDbContext.SaveChanges();
        }
    }
}

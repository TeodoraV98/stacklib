using stacklib.BLL.Repository;
using stacklib.DAL.Entities;

namespace stacklib.BLL.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public IEnumerable<Book> GetAllBooks()
    {
        return _bookRepository.GetAllBooks();
    }

    public Book GetBookById(int id)
    {
        return _bookRepository.GetBookById(id);
    }

    public void AddBook(Book book)
    {
        _bookRepository.AddBook(book);
    }

    public void UpdateBook(int id, Book updatedBook)
    {
        _bookRepository.UpdateBook(id, updatedBook);
    }

    public void DeleteBook(int id)
    {
        _bookRepository.DeleteBook(id);
    }
}

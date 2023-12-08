using stacklib.DAL.Entities;

namespace stacklib.BLL.Services;

public interface IBookService
{
    IEnumerable<Book> GetAllBooks();
    Book GetBookById(int id);
    void AddBook(Book book);
    void UpdateBook(int id, Book updatedBook);
    void DeleteBook(int id);
}

using stacklib.DAL.Entities;


namespace stacklib.BLL.Repository;

public interface IBookRepository
{
    IEnumerable<Book> GetAllBooks();
    Book GetBookById(int id);
    void AddBook(Book book);
    void UpdateBook(int id, Book updatedBook);
    void DeleteBook(int id);
}

using Microsoft.AspNetCore.Mvc;
using stacklib.BLL.Repository;
using stacklib.BLL.Services;
using stacklib.DAL.Entities;

namespace stacklib.Controllers;

[ApiController]
[Route("api/books")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    // GET: api/books
    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetBooks()
    {
        var books = _bookService.GetAllBooks();
        return Ok(books);
    }

    // GET: api/books/{id}
    [HttpGet("{id}")]
    public ActionResult<Book> GetBookById(int id)
    {
        var book = _bookService.GetBookById(id);
        if (book == null)
        {
            return NotFound();
        }
        return Ok(book);
    }

    // POST: api/books
    [HttpPost]
    public ActionResult<Book> CreateBook(Book book)
    {
        _bookService.AddBook(book);
        return CreatedAtAction(nameof(GetBookById), new { id = book.BookId }, book);
    }

    // PUT: api/books/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, Book updatedBook)
    {
        var book = _bookService.GetBookById(id);
        if (book == null)
        {
            return NotFound();
        }

        book.BookTitle = updatedBook.BookTitle;
        book.BookAuthor = updatedBook.BookAuthor;
        book.BookISBN = updatedBook.BookISBN;
        book.BookPublishingHouse = updatedBook.BookPublishingHouse;
        book.BookLanguage = updatedBook.BookLanguage;
        book.BookPublicationDate = updatedBook.BookPublicationDate;
        book.BookPageCount = updatedBook.BookPageCount;

        _bookService.UpdateBook(id, book);
        return NoContent();
    }

    // DELETE: api/books/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        var book = _bookService.GetBookById(id);
        if (book == null)
        {
            return NotFound();
        }

        _bookService.DeleteBook(id);
        return NoContent();
    }
}
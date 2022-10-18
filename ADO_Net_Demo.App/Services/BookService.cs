using ADO_Net_Demo.App.DB;
using ADO_Net_Demo.App.Models;

namespace ADO_Net_Demo.App.Services;

public class BookService
{
    private readonly ICrud _db;

    public BookService(ICrud db)
    {
        _db = db;
    }

    public IEnumerable<Book> GetAllBooks()
    {
        return _db.GetAllBooks();
    }
}

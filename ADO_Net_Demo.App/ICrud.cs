using ADO_Net_Demo.App.Models;

namespace ADO_Net_Demo.App;

public interface ICrud
{
    public IEnumerable<Book> GetAllBooks();
}

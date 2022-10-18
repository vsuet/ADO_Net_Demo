using ADO_Net_Demo.App.DB;
using ADO_Net_Demo.App.Services;

var db = new BookService(new MySqlDb());

var books = db.GetAllBooks();
foreach (var book in books)
{
    Console.WriteLine($"{book.Title}, {book.Author.LastName} {book.Author.FirstName}, {book.Genre}");
}

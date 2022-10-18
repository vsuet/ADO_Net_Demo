using ADO_Net_Demo.App.DB;

var db = new Db();

var books = db.GetAllBooks();
foreach (var book in books)
{
    Console.WriteLine($"{book.Title}, {book.Author.LastName} {book.Author.FirstName}, {book.Genre}");
}

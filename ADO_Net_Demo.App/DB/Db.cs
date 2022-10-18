using ADO_Net_Demo.App.Models;
using DbConfigLib;
using MySql.Data.MySqlClient;

namespace ADO_Net_Demo.App.DB;

public class Db
{
    private MySqlConnection _db;

    public Db()
    {
        _db = new MySqlConnection(DbConfig.ImportFromJson().ToString());
    }

    public List<Book> GetAllBooks()
    {
        var books = new List<Book>();

        _db.Open();

        const string sql = @"
SELECT title, last_name, first_name, genre
FROM table_books
JOIN table_authors
    ON table_books.author_id = table_authors.author_id
JOIN table_genres
    ON table_books.genre_id = table_genres.genre_id;
        ";
        var command = new MySqlCommand(sql, _db);
        var result = command.ExecuteReader();
        if (result.HasRows)
        {
            while (result.Read())
            {
                books.Add(new Book()
                {
                    Title = result.GetString("title"),
                    Genre = result.GetString("genre"),
                    Author = new Author()
                    {
                        LastName = result.GetString("last_name"), FirstName = result.GetString("first_name")
                    }
                });
            }
        }

        _db.Close();

        return books;
    }
}

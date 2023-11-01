// Handle operations on books

using ConsoleApp.Entity;

namespace ConsoleApp.Service
{
    public class BookService
    {
        public BookService()
        {

        }

        // Create Book list from <name, author> dictionary
        public static List<Book> CreateBooks(Dictionary<string, string> values)
        {
            List<Book> books = new();

            foreach (KeyValuePair<string, string> pair in values)
            {
                Book book = new(pair.Key, pair.Value);
                books.Add(book);
            }

            return books;
        }

        // Organize books by author using a dictionary <author, List<Book>>
        public static Dictionary<string, List<string>> GetBooksByAuthor(List<Book> books)
        {
            Dictionary<string, List<string>> keyValuePairs = new();

            foreach (Book book in books)
            {
                if (keyValuePairs.ContainsKey(book.Author))
                {
                    keyValuePairs[book.Author].Add(book.Name);
                }
                else
                {
                    List<string> names = new()
                {
                    book.Name
                };
                    keyValuePairs.Add(book.Author, names);
                }

            }

            return keyValuePairs;
        }

        // Order Book list by name (A-Z)
        public static List<Book> OrderBooksByName(List<Book> books)
        {
            List<Book> orderedBooks = new();

            orderedBooks = books.OrderBy(book => book.Name).ToList();

            return orderedBooks;
        }

        // Order Book list by author (A-Z)
        public static List<Book> OrderBooksByAuthor(List<Book> books)
        {
            List<Book> orderedBooks = new();

            orderedBooks = books.OrderBy(book => book.Author).ToList();

            return orderedBooks;
        }

        // Print books in console
        public static void PrintBooks(List<Book> books)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.Name + ", " + book.Author);
            }
        }
    }
}
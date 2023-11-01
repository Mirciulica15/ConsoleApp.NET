using ConsoleApp.Entity;
using ConsoleApp.Service;

internal class Program
{
    private static void Main()
    {
        Dictionary<string, string> values = new()
        {
            { "Book1", "Messi" },
            { "Book2", "Messi" },
            { "Book3", "Andrei" }
        };

        List<Book> books = BookService.CreateBooks(values);

        BookService.PrintBooks(books);

        List<Book> orderedBooksByName = BookService.OrderBooksByName(books);

        BookService.PrintBooks(orderedBooksByName);

        List<Book> orderedBooksByAuthor = BookService.OrderBooksByAuthor(books);

        BookService.PrintBooks(orderedBooksByAuthor);

        Dictionary<String, List<String>> keyValuePairs = BookService.GetBooksByAuthor(books);

        foreach (String key in keyValuePairs.Keys)
        {
            Console.Write(key + ": ");
            foreach (String value in keyValuePairs[key])
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

        //String[] bookNames = new String[3] { "Book1", "Book2", "Book3" };
        //User user = new User("Mircea", "mircea@gmail.com");
        //Book[] books = new Book[3];
        //for (int i = 0; i < 3; i++)
        //{
        //    books[i] = new Book(bookNames[i], "Paulo Coelho");
        //}

        //Console.WriteLine("Hello, which books do you want to read?");

        //for (int i = 0; i < books.Length; i++)
        //{
        //    Console.Write(books[i].Name + books[i].Author + " ");
        //}

        //Console.WriteLine();

        //int j;
        //j = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(j);
        //user.Books.Add(books[j]);

        //Console.WriteLine("Do you still want more books? (yes/no)");
        //String ?answer = Console.ReadLine();
        //if(answer != null)
        //{
        //    if(answer == "no")
        //    {
        //        Console.WriteLine(user.Books);
        //        return;
        //    } else
        //    {
        //        Console.WriteLine("Which ones?");
        //    }
        //}
        //j = Convert.ToInt32(Console.ReadLine());

        //user.Books.Add(books[j]);

        //foreach (Book b in user.Books)
        //{
        //    Console.WriteLine(b.Name + " " + b.Author);
        //}

    }
}

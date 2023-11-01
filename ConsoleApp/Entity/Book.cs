namespace ConsoleApp.Entity
{
    public class Book
    {
        private string name;
        private string author;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
    }
}
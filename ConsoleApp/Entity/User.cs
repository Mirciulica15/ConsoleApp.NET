using ConsoleApp.Entity;

class User
{
    private String name;
    private String email;
    public List<Book> Books { get; set; }

    public String Name
    {
        get { return name; }
        set { name = value; }
    }

    public String Email
    {
        get { return email; }
        set { email = value; }
    }

    public User(String name, String email)
    {
        this.name = name;
        this.email = email;
        Books = new List<Book>();
    }

}

namespace PublisherDomain;

public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public List<Book> Books { get; set; } = new List<Book>();
}

namespace PublisherDomain;

public class Book
{
    public int BookId { get; set; }
    private string Title { get; set; } = default!;
    public DateOnly PublishDate { get; set; }
    public decimal BasePrice { get; set; }
    public Author Author { get; set; } = default!;
}

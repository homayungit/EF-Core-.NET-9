using PublisherData;

using (PubContext context = new PubContext())
{
    context.Database.EnsureCreated();
}

GetAuthor();

void GetAuthor()
{
    using var context = new PubContext();
    var author = context.Authors.ToList();

    foreach (var authorItem in author)
    {
        Console.WriteLine($"{authorItem.FirstName}  and {authorItem.LastName}");
    }
}

namespace ClassLibrary1
{
    public abstract class Book
    {
        // I decided to make it as private 
        // I think it is a good idea because the tittle and author should 
        // only be initialized in the constructor or during declaration
        public string Title { get; }
        public int BookId { get; }
        public string Author { get; }
        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }

    }
    
}
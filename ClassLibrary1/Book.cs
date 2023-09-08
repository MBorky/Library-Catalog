namespace ClassLibrary1
{
    public class Book
    {
        // I decided to make it as private 
        // I think it is a good idea because the tittle and author should 
        // only be initialized in the constructor or during declaration
        public string Title { get; }
        public string Author { get; }
        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }
        public void PrintBookInfo()
        {
            Console.WriteLine($"Author: {Author}, Tittle: {Title}");
        }

    }
    
}
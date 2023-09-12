namespace ClassLibrary1
{
    public abstract class Book
    {
        
        public string Title { get; }
        // store key from dictionary userlist. If someone borrow book there is this person key
        public int Borrower { get; set; } = 0;
        public int BookId { get; private set; }
        public string Author { get; }
        public Book(string author, string title, int bookId)
        {
            this.Author = author;
            this.Title = title;
            this.BookId = bookId;
        }

    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class NonFictionBook : Book
    {
        public NonFictionBook(string author, string title, int bookId)
        : base(author, title, bookId) { }
        
        public override string ToString()
        {
            return ($"Author: {Author}, title: {Title}");
        }
    }
}

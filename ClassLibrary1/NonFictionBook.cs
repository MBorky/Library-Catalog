using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class NonFictionBook : Book
    {
        public NonFictionBook(string author, string title)
        : base(author, title) { }
        
        public override string ToString()
        {
            return ($"Author: {Author}, title: {Title}");
        }
    }
}

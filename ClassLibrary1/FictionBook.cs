﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class FictionBook : Book
    {
        public string LiteraryGenre { get; private set; }
        public FictionBook(string author, string title, int bookId, string literaryGenre)
            : base(author, title, bookId)
        {
            LiteraryGenre = literaryGenre;
        }
        public override string ToString()
        {
            return ($"Author: {Author}, title: {Title}, Literary Genre {LiteraryGenre}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace task02.Models
{
    public class AuthorBookGenreMap
    {
        public int BookGenreMapID { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; }

        public int GenreID { get; set; }
        public Genre Genre { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace task02.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int BookYear { get; set; }

        public int AuthorID { get; set; }
        public Author Author { get; set; }

        public ICollection<BookGenreMap> BookGenreMaps { get; set; }


    }
}

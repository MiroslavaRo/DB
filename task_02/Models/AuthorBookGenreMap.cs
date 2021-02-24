using System;
using System.Collections.Generic;
using System.Text;

namespace task_02.Models
{
    public class AuthorBookGenreMap
    {
        public int AuthorBookGenreMapID { get; set; }
        public int AuthorID { get; set; }

        public int BookID { get; set; }

        public int GenreID { get; set; }

    }
}


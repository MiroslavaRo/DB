using System;
using System.Collections.Generic;
using System.Text;

namespace task_03.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        public ICollection<BookGenreMap> BookGenreMaps { get; set; }
    }
}

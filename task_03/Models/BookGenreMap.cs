using System;
using System.Collections.Generic;
using System.Text;

namespace task_03.Models
{
    public class BookGenreMap
    {
        public int BookGenreMapID { get; set; }
        public int? BookID { get; set; }

        public int? GenreID { get; set; }
    }
}

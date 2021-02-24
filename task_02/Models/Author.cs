using System;
using System.Collections.Generic;
using System.Text;

namespace task_02.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}

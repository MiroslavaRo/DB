using System;
using System.Collections.Generic;

#nullable disable

namespace task_01.Models
{
    public partial class Product
    {
        public int IdProduct { get; set; }
        public string NameProduct { get; set; }
        public int? Price { get; set; }
        public int IdManufacture { get; set; }

        public virtual Manufacture IdManufactureNavigation { get; set; }
    }
}

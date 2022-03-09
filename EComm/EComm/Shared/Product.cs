using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm.Shared
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product must have a name")]
        public string? ProductName { get; set; }
        public int SupplierId { get; set; }

        [Required, Range(0.01, 10000.0)]
        public Decimal? UnitPrice { get; set; }

        public string? Package { get; set; }
        
        public bool IsDiscontinued { get; set; }

        public Supplier? Supplier { get; set; }
    }
}

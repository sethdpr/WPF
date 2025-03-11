using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WPF.Models
{
    public class BestellingProduct
    {
        [Key]
        public int BestellingProductId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Aantal { get; set; }
        public int BestellingId { get; set; }
        public Bestelling Bestelling { get; set; }
    }
}

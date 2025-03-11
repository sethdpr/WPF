using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WPF.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }

        public List<BestellingProduct> BestellingProducten { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WPF.Models
{
    public class Bestelling
    {
        [Key]
        public int BestellingId { get; set; }
        public int KlantId { get; set; }
        public string Naam { get; set; }
        public DateTime Datum { get; set; }
        public List<BestellingProduct> BestellingProducten { get; set; }
    }
}

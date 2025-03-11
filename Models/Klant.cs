using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WPF.Models
{
    public class Klant
    {
        [Key]
        public int KlantId { get; set; }
        public string Naam { get; set; }
        public List<Bestelling> Bestellingen { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.ORM.Entity
{
    public class Oteller : BaseEntity
    {
        [Required]
        public string OtelAdı { get; set; }
        [Required]
        public string YıldızSayısı { get; set; }
        [Required]
        public double GünlükFiyatı { get; set; }
        [Required]
        public int OdaSayısı { get; set; }
        [Required]
        public string Havuz { get; set; }
        [Required]
        public string SporSalonu { get; set; }
        [Required]
        public string Adres { get; set; }
        public string ImageUrl { get; set; }

        List<Yoneticiler> Yoneticilers = new List<Yoneticiler>();
    }
}

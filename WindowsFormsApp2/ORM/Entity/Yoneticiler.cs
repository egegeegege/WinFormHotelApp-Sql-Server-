using System.Collections.Generic;
using Microsoft.Build.Framework;

namespace WindowsFormsApp2.ORM.Entity
{
    public  class Yoneticiler : BaseEntity
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string TelefonNo { get; set; }
        [Required]
        public string Sifre { get; set; }

        List<Oteller> Otellers = new List<Oteller>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace WindowsFormsApp2.ORM.Entity
{
    public abstract class BaseEntity
    {
        [Required]
        public int ID { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        [Required]
        public bool Aktifmi { get; set; }
    }
}

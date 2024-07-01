using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.ORM.Entity
{
    public class Rezervasyon : BaseEntity
    {
        public int OdaID { get; set; }
        public int YoneticiID { get; set; }

        public virtual Oteller Oteller { get; set; }
        public virtual Yoneticiler Yoneticiler { get; set; }

        public DateTime RezerveTarihi { get; set; }
        public DateTime OdaTeslimTarihi { get; set; }
        public int? KullanımSuresi { get; set; }
        public double FaturaTutari { get; set; }
    }
}

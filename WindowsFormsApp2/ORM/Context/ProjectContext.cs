using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.ORM.Entity;

namespace WindowsFormsApp2.ORM.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
			Database.Connection.ConnectionString = "Server=DESKTOP-L027AII\\SQLEXPRESS;Database=ALog;uid=sa;pwd=1453";
		}
        public DbSet<Oteller> Otellers { get; set; }
        public DbSet<Yoneticiler> Yoneticilers { get; set; }
        public DbSet<Rezervasyon> Rezervasyons { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kozos.Data
{
    public class RendelesekContext : DbContext
    {


        public DbSet<Models.Rendeles> Rendelesek { get; set; } 
        public DbSet<Models.Ugyfel> Ugyfelek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=KetTablasNyilvantartas;Trusted_Connection=True;");
        }
    }
}

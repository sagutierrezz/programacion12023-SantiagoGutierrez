using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ConexionBD
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }
        public DbSet<TarjetaCredito> TarjetasCredito { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KPP34V4\\SQLEXPRESS;database=BancoDB1;trusted_connection=true;Encrypt=False");
        }
    }
}

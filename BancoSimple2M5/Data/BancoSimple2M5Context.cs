using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoSimple2M5.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoSimple2M5.Data
{
    public class BancoSimple2M5Context : DbContext
    {
        public DbSet <Cliente> Clientes { get; set; } 
        public DbSet <Cuenta> Cuentas { get; set;}
        public DbSet <Transaccion> Transacciones { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer (@"Server =RAFAELESPINOZA\SQLSERVER2019; database = BancoSimple2M5; trusted_Connection = true; trustserverCertificate = true;");
        }

        //Definicion de filtro Global
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>().HasQueryFilter (c => c.Activo);
        }
    }
}

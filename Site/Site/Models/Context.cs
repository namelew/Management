using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site
{
    public class Context : DbContext
    {
        // criação das tabelas
        public DbSet<Produto> Estoque { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Log> Historico { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=LojaVirtual;Integrated Security=True");
        }
    }
}

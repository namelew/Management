using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteAgoraVai.Models
{
    public class MainContext: DbContext
    {
        public DbSet<Produto> Estoque { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Transacoes> Transacoes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=LAPTOP-R05G5P3G;initial catalog=master;trusted_connection=true");
        }
    }
}

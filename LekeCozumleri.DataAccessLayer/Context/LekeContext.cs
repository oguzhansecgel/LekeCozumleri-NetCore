using LekeCozumleri.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.DataAccessLayer.Context
{
    public class LekeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-21DNK0N;initial catalog = LekeCozumleri; integrated security=true; TrustServerCertificate=True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Stain> Staines { get; set; }
    }
}

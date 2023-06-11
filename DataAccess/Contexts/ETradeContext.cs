using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class ETradeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=laptop-8c0i0fnb;Database=ETradeDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

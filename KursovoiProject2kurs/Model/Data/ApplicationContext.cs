using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovoiProject2kurs.DataModel
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Support> Supports { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ManageAppDBLAST1;Trusted_Connection=True;");
        }
    }
}

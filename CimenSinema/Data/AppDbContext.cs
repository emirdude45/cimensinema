using Microsoft.EntityFrameworkCore;
using CimenSinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimenSinema.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=..\\..\\files\\CimenSinemaDb.db");
        }

        public DbSet<Film> Film { get; set; }
        public DbSet<Seans> Seans { get; set; }
        public DbSet<Rezervasyon> Rezervasyon { get; set; }
    }
}

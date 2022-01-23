using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using web_api.Controllers.Models;
using web_api.Models;

namespace web_api.Context
{
    public class MainContext : DbContext
    {
        public DbSet <Prodaja> Prodajas { get; set; }
        public DbSet <Tovar> Tovars { get; set; }
        public DbSet <Sotrydnik> Sotrydniks { get; set; }
        public DbSet <Doljnost> Doljnosts { get; set; }
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tovar>()
                .ToTable("Tovar");
            modelBuilder.Entity<Doljnost>()
                .ToTable("Doljnost");
            modelBuilder.Entity<Sotrydnik>()
                .ToTable("Sotrydnik");
            modelBuilder.Entity<Prodaja>()
                .ToTable("Prodaja");
        }
    }
}

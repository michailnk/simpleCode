using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF2 {
    class Program {
        static void Main(string[] args) {
    

        }
    }

    class AppContext : DbContext {
        // first variant
        public DbSet<Phone> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestDb_01;Trusted_Connection=true;");
        }

        // third variant override OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Cars>();
            //modelBuilder.Ignore<Company>(); 
            //modelBuilder.Entity<Phone>().Ignore(pp => pp.CurrentRate);
        }
    }

     class Cars {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Phone {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        // second variant  add field  it's navigation property
        public Company Manufacturer { get; set; }
        //[NotMapped]
        public int CurrentRate { get; set; }
    }

    //[NotMapped]
    class Company {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

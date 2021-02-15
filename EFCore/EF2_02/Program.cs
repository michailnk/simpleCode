using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF2_02 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }

    class AppDbContext : DbContext {
        public DbSet<User> Users { get; set; }
        AppDbContext() {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestDb_202;Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().ToTable("People", schema: "userstory");
            modelBuilder.Entity<User>().Property(p=>p.Id).HasColumnName("UserID");
        }
    }

    //[Table("People")]
    public class User {
        //[Column("UserID")]
        public int Age { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
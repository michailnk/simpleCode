using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            using (AppContext context = new AppContext()) {
                context.Users.Add(new User() { Name = "Vitalii", Age = 22 });
                context.SaveChanges();
            }

            using (AppContext context = new AppContext()) {
                User us2 = new User { Name = "Tom", Age = 30 };
                User us3 = new User { Name = "Alice", Age = 27 };

                context.Users.Add(us2);
                context.Users.Add(us3);
                context.SaveChanges();
            }
            using (AppContext context = new AppContext()) {
                var list = context.Users.ToList();
                var res = list.Where(x => x.Id == 2).FirstOrDefault();
                res.Age = 28;
                context.SaveChanges();
            }

            using (AppContext context = new AppContext()) {
                var list = context.Users.ToList();
                foreach (var item in list) {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Age}");
                }
            }
        }
    }

    class User {

        public int Age { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }

    class AppContext : DbContext {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestDb1;Trusted_Connection=true");
        }
    }
}


/////dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.3
//Install - Package Microsoft.EntityFrameworkCore
//  dotnet add package Microsoft.EntityFrameworkCore.SqlServer
//dotnet add package Microsoft.EntityFrameworkCore.Design
//Install-Package Microsoft.EntityFrameworkCore.SqlServer
//Install-Package Microsoft.EntityFrameworkCore.Design
//Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore
//Install-Package Microsoft.EntityFrameworkCore.Tools
//add-migration NameMigration
//update-database
// подключение к существующей БД
// scaffold-DbContext "Server=(localdb)\\mssqllocaldb;Database=TestDb1;Trusted_Connection=true;" Microsoft.EntityFrameworkCore.SqlServer 
using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_01 {
    class Program {
        static void Main(string[] args) {
            // База данных сотрудников.
            var employees = new List<Employee>
            {
                new Employee {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Salary = 94800,
                    StartDate = DateTime.Parse("01/04/1992")
                },
                new Employee {
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Salary = 123990,
                    StartDate = DateTime.Parse("12/03/1985")
                },
                new Employee {
                    FirstName = "Andrew",
                    LastName = "Andreev",
                    Salary = 1000000,
                    StartDate = DateTime.Parse("01/12/2005")
                }

            };

            var query = from employee in employees
                        where employee.Salary > 150000
                        orderby employee.LastName, employee.FirstName
                        select new {
                            LastName = employee.LastName,
                            FistName = employee.FirstName
                        };
            //Выражение запроса.(Использование вызовов extendens методов.)
            var query1 = employees
                .Where(emp => emp.Salary > 150000)
                .OrderBy(em => em.LastName)
                .OrderBy(em => em.FirstName)
                .Select(e => new {
                    LastName = e.LastName,
                    FistName = e.FirstName
                });
            // Выражение запроса.(Использование вызовов статических методов.)
            var quer2 =           
                Enumerable.Select(  
                    Enumerable.OrderBy(
                    Enumerable.OrderBy(
                    Enumerable.Where(
                    employees, emp => emp.Salary > 1500000),
                    em => em.LastName),
                    em => em.FirstName),
                    em => new { LastName = em.LastName, FirstName = em.FirstName });

            Console.WriteLine("Hight salary:");

            foreach (var item in query1) {
                Console.WriteLine($" {item.LastName} {item.FistName}");
            }

            Console.ReadKey();
        }

        internal class Employee {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Salary { get; set; }
            public DateTime StartDate { get; set; }
        }
    }
}
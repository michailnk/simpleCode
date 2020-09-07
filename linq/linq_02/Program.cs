using System;
using System.Linq;

namespace linq_02 {
    class Program {
        static void Main(string[] args) {
            var query = from x in Enumerable.Range(1, 9)
                        from y in Enumerable.Range(1, 9)
                        select new {
                            X = x,
                            Y = y,
                            Prod = x * y
                        };
            foreach(var item in query)
                Console.WriteLine($"{item.X} * {item.Y} = {item.Prod}");
        }
    }
}

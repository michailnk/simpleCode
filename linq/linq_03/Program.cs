using System;
using System.Linq;

namespace linq_03 {
    // let - представляет новый локальный идентификатор, на который можно ссылаться в остальной части запроса. 
    // Его можно представить, как локальную переменную видимую только внутри выражения запроса.
    class Program {
        static void Main(string[] args) {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query1 = from i in numbers
                         group i by i % 3;

            foreach (var group in query1) {
                Console.WriteLine($" mod{group.Key} - {group.Key}");
                foreach (var item in group) {
                    Console.WriteLine(item);
                }
            }

            var query = from j in numbers
                        group j by j % 2 into part
                        where part.Key == 0
                        select new { Key = part.Key, Count = part.Count(), Group = part };
            foreach(var item in query) {
                Console.WriteLine($"mod {item.Key}");
                Console.WriteLine($"count {item.Count}");
                foreach (var i in item.Group) {
                    Console.Write(i+", ");
                }
            }
            Console.WriteLine();
            //var query = from x in Enumerable.Range(1, 9)
            //            let innerRange = Enumerable.Range(1, 9) //let
            //            from y in innerRange
            //            select new { X = x, Y = y, Prod = x * y };
            //foreach (var item in query) {
            //    Console.WriteLine($"{item.X} {item.Y} = {item.Prod}");
            //}
        }
    }
}

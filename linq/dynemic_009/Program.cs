using System;
using System.Collections;
namespace dynemic_009 {
    // привидение типа (cast) к другому типу без инкопсуляции является Ad-hoc полиморфизмом
    class UserCollection
        {
        public static IEnumerable GetEnumerable() {
            yield return new { Key =  0, Value = "zero" };
            yield return new { Key =  1, Value = "one" };
            yield return new { Key =  2, Value = "two" };
        }
    }

    public interface IEnumerale {
    }

    class Program {
        static void Main(string[] args) {
            
            foreach(dynamic item in UserCollection.GetEnumerable()) {
                Console.WriteLine($" Key = {item.Key} Value = {item.Value}") ;
            }
        }
    }
}

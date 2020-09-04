using System;

namespace exception_05 {
    class Program {
        static void Main(string[] args) {

            try {
                throw null;
                // та строка эквивалентна следующему
                //Exception my = null;
                //throw my;
            }
            catch(NullReferenceException ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }
    }
}
 
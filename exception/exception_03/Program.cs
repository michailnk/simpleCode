using System;

namespace exception_03 {

    // finally  -  не срабатывает если  не  завершается  работа  блока  catch.
    class Program {
        static void Main(string[] args) {

            try {
                throw new Exception();
            }
            catch(Exception e) {
                //finally isn't work

                while (true) {
                    Console.WriteLine("catch");
                }

                //or same
                throw new Exception();  
            }

            finally {
                while (true) {
                    Console.WriteLine("finally");
                }
            }

            Console.ReadKey();
        }
    }
}

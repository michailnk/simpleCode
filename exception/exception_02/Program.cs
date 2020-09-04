using System;
namespace exception_02 {

// finally - не срабатывает в случае возникновения исключения StackOverflowException.

    class Program {
        public static void Method() {
            int[] arr = new int[100];
            Console.WriteLine(arr);
            Method();
        }
        static void Main(string[] args) {

            try {
                Method();
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }

            // finaly не обрабатывается
            finally {
                while (true) {
                    Console.WriteLine("Finaly");
                }
            }
        }
    }
}

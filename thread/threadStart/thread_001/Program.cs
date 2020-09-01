using System;
using System.Threading;

namespace thread_001 {
    class Program {
        static void WriteSecond() {
            while (true) {
                Console.WriteLine(new string(' ',10) + "secondary");
            }
        }
        static void Main(string[] args) {

            ThreadStart thStart = new ThreadStart(WriteSecond);
            Thread th = new Thread(thStart);
            th.Start();

            while (true) {
                Console.WriteLine( "primary");
            }
        }
    }
}

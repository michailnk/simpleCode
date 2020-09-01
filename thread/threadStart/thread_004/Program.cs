using System;
using System.Threading;

namespace thread_004 {
    // замыкания  closures
    class Program {
        static void Main(string[] args) {
            int counter = 0;

            Thread th = new Thread(delegate () { Console.WriteLine($" 1. counter = {++counter}"); }); // closures
            th.Start();

            Thread.Sleep(0); // make comment
            Console.WriteLine($" 2. counter = {counter}");
            th = new Thread((object argument) => { Console.WriteLine($" 3. counter = {(int)argument}"); });
            th.Start(counter);
            Console.ReadKey();
        }
    }
}

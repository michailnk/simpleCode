using System;
using System.Threading;

namespace thread_003 {
    class Program {

        static void WriteSecondary(object argument) {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(argument);
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args) {
            ParameterizedThreadStart pth = WriteSecondary;
            Thread th = new Thread(pth);
            th.Start("Hi!");

            Thread.Sleep(500);
            Console.WriteLine("end main");
            Console.ReadKey();
        }
    }
}

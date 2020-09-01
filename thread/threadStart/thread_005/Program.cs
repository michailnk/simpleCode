using System;
using System.Threading;

namespace thread_005 {
    class Program {
         static object locker = new object();
        public static void WriteSecond(object obj) {
            var color = (ConsoleColor)obj;
            for (int i = 0; i < 20; i++) {
                //lock (locker)
                    {
                    Console.ForegroundColor = color; // ConsoleColor.Yellow;
                    Console.WriteLine(new string(' ', 10) + "secondary");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(120);
                }
            }
        }
        static void Main(string[] args) {
            ParameterizedThreadStart ths = WriteSecond;
            new Thread(ths).Start(ConsoleColor.Yellow);

            for (int i = 0; i < 20; i++) {
                lock (locker) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("primary");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(120);
                }
            }
        }
    }
}

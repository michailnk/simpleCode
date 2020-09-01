using System;
using System.Threading;

namespace thread_002 {
    class Program {
        static void WriteSecond() {
            // CLR назначает каждому потоку свой стек и методы имеют свои собственные локальные переменные. 
            // Отдельный экземпляр переменной counter создается в стеке каждого потока, 
            // поэтому для каждого потока выводятся, свои значения counter - 0,1,2.

            int counter = 0;
            while (counter <10) {
                //Thread.Sleep(100);
                Console.WriteLine($"ThreadId {Thread.CurrentThread.GetHashCode()} counter = {counter++}");
            }
        }
        static void Main(string[] args) {
            Thread th = new Thread(WriteSecond);
            th.Start();

            WriteSecond();
        }
    }
}

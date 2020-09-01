using System;
using System.Threading;

namespace thread_006 {

    class MyClass {
        object block = new object();
        int hash = Thread.CurrentThread.GetHashCode();
        public void Method() {
            lock (block) 
                {
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine($"thread: {hash} step: {i}");
                    Thread.Sleep(200);
                }
                Console.WriteLine(new string('_', 20));
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            MyClass mc = new MyClass();
            for (int i = 0; i < 3; i++) {
                new Thread(mc.Method).Start();
                //Thread.Sleep(100);
            }
            Thread.Sleep(300);
            Console.ReadKey();
        }
    }
}

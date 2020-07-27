using System;
using System.Diagnostics;
using System.Threading;

namespace _04_MemberwiseClone {
    class MyClass {
        static Random random = new Random();
        private int a, b;
        public MyClass() {
            a = random.Next(0, 100);
            Thread.Sleep(3000);
            b = random.Next(0, 100);
        }
        public object Clone() {
            return this.MemberwiseClone();
        }

        public override bool Equals(object obj) {
            return obj is MyClass @class &&
                   a == @class.a &&
                   b == @class.b;
        }

        public override int GetHashCode() {
            return HashCode.Combine(a, b);
        }
    }
    class Program {
        static void Main(string[] args) {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            MyClass origin = new MyClass();
            timer.Stop();
            Console.WriteLine(timer.Elapsed.Ticks);
            timer.Reset();

            timer.Start();
            MyClass clone = origin.Clone() as MyClass;
            Console.WriteLine(timer.Elapsed.Ticks);
            timer.Reset();

            Console.WriteLine(origin.Equals(clone));

        }
    }
}

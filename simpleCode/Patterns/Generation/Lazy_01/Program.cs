using System;
using System.Threading;
namespace Lazy_01 {

    public sealed class BigData {
        public BigData() {
            Thread.Sleep(3000);
            Console.WriteLine("Instance is created");
        }

        public void Operation() {
            Console.WriteLine("Operation");
        }
    }
    class Program {
        static void Main(string[] args) {
            System.Lazy<BigData> lazy = new Lazy<BigData>();
            Console.WriteLine("first turning to a BigData");
            lazy.Value.Operation();
            Console.WriteLine("second turning to a BigData");
            lazy.Value.Operation();
        }
    }
}

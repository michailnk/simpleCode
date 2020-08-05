using System;
/// <summary>
/// Object level adapter
/// </summary>
namespace _12_Adapter_2 {
    abstract class Target {
        public abstract void Request();
    }

    class Adaptee {
        public void SpecificalRequest() {
            Console.WriteLine("SpecificalRequest");
        }
    }

    class Adapter: Target {
        Adaptee adaptee = new Adaptee();
        public override void Request() {
            adaptee.SpecificalRequest();
        }
    }
    class Program {
        static void Main(string[] args) {
            Target target = new Adapter();
            target.Request();
        }
    }
}

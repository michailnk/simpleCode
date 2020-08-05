using System;
/// <summary>
/// Adapter a level class's
/// </summary>
namespace _12_Adapter {

    class Adaptee {
        public void SpecificRequest() {
            Console.WriteLine("SpecificRequest");
        }
    }

    interface ITarget {
        void Request();
    }

    class Adapter : Adaptee, ITarget {
        public void Request() {
            SpecificRequest();
        }
    }

    class Program {
        static void Main(string[] args) {
            ITarget target = new Adapter();
            target.Request();
        }
    }
}

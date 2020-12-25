using ConsoleApp3.AbsFactoryies;
using System;

namespace ConsoleApp3 {
    class Program {
        static void Main(string[] args) {
            AbsFactory f = null;

            //f = new ColaFactory();
            f = new PepsiFactory();

            Client.Client client = new Client.Client(f);
            Console.WriteLine(f.GetBottle());
            Console.WriteLine(f.GetWatter());
            client.Interact();
        }
    }
}

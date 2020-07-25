using System;

namespace _01_AbsFactory {

    abstract class AbsFactory {
        public abstract AbsBottle CreateBottle();
        public abstract AbsWater CreateWater();

    }

    abstract class AbsWater { }

    abstract class AbsBottle {
        public abstract void Interact(AbsWater water);
    }

    class ColaWater : AbsWater { }
    class ColaBottle : AbsBottle {
        public override void Interact(AbsWater water) {
            Console.WriteLine( this.GetType().Name + " add "+ water.GetType().Name);
        }
    }
    class PepsiWater : AbsWater { }
    class PepsiBottle : AbsBottle {
        public override void Interact(AbsWater water) {
            Console.WriteLine(this.GetType().Name + " add " + water.GetType().Name);
        }
    }

    class ColaFactory : AbsFactory {
        public override AbsBottle CreateBottle() {
            return new ColaBottle();
        }

        public override AbsWater CreateWater() {
            return new ColaWater();
        }
    }

    class PepsiFactory : AbsFactory {
        public override AbsBottle CreateBottle() {
            return new PepsiBottle();
        }

        public override AbsWater CreateWater() {
            return new PepsiWater();
        }
    }

    class Client {
        AbsBottle bottle;
        AbsWater water;
        public Client(AbsFactory factory) {
            bottle = factory.CreateBottle();
            water = factory.CreateWater();
        }

        public void Run() {
            bottle.Interact(water);
        }
    }
    class Program {
        static void Main(string[] args) {
            Client client = new Client(new ColaFactory());
            client.Run();

            client = new Client(new PepsiFactory());
            client.Run();
        }
    }
}

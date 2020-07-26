using System;
using System.Collections;

namespace _02_Builder {

    class Foreman {
        Builder builder;

        public Foreman(Builder builder) {
            this.builder = builder;
        }

        public void Construct() {
            builder.BuildBasement();
            builder.BuildStorey();
            builder.BuildRoof();
        }
    }

    abstract class Builder {
        public abstract void BuildBasement();
        public abstract void BuildStorey();
        public abstract void BuildRoof();
        public abstract House GetHouse();
    }

    public class Roof {
        public Roof() => Console.WriteLine("the roof is built");
    }
    public class Storey {
        public Storey() => Console.WriteLine("the storey is built");
    }
    public class Basement {
        public Basement() => Console.WriteLine("the basment is built");
    }

    class ConcreteBuilder : Builder {
        House house = new House();
        public override void BuildBasement() {
            house.AddPart(new Basement());
        }
        public override void BuildRoof() {
            house.AddPart(new Roof());
        }
        public override void BuildStorey() {
            house.AddPart(new Storey());
        }
        public override House GetHouse() { return house; }
    }

    class House {
        ArrayList list = new ArrayList();
        public void AddPart(Object part) {
            list.Add(part);
        }
    }

    class Program {
        static void Main(string[] args) {
            Builder builder = new ConcreteBuilder();
            Foreman foreman = new Foreman(builder);
            foreman.Construct();

            House house = builder.GetHouse();

            Console.ReadKey();
        }
    }
}
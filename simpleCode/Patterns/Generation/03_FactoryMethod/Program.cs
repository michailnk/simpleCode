using System;

namespace FactoryMethod {

    abstract class Creator {
        Product product;
        public abstract Product FactoryMethod();
        public void AnOperation() {
            product = FactoryMethod();
        }
    }

    abstract class Product { }

    class ConcreteProduct : Product {
        public ConcreteProduct() {
            Console.WriteLine(this.GetHashCode());
        }
    }

    class ConcreteCreator : Creator {
        public override Product FactoryMethod() {
            return new ConcreteProduct();
        }
    }

    class Program {
        static void Main(string[] args) {
            Creator creator = null;
            Product product = null;

            creator = new ConcreteCreator();
            product = creator.FactoryMethod();

            creator.AnOperation();
        }
    }
}

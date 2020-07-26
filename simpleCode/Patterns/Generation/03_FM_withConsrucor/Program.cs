using System;

namespace _03_FM_withConsrucor {

    abstract class Product { }
    class DefaultProd : Product { }
    class SpecialProd : Product { }

    abstract class Creator {
        protected Product product = null;
        public Creator() {
            product = FactoryMethod();
            Console.WriteLine(product.GetType().Name);
        }
        public virtual Product FactoryMethod() {
            return new DefaultProd();
        }
    }
    class SpecCreator : Creator {
        public SpecCreator() {
            product = FactoryMethod();
            Console.WriteLine(product.GetType().Name);
        }
        public override Product FactoryMethod() {
            //public new Product FactoryMethod() {
            return new SpecialProd();
        }
    }
    class Program {
        static void Main(string[] args) {
            Product galaxy = new SpecCreator().FactoryMethod();
        }
    }
}

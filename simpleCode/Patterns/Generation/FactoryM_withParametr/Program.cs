using System;

namespace FactoryM_withParametr {

    abstract class Product {
        public Product() {
            Console.WriteLine(this.GetType().Name);
        }
    }

    class First : Product { }
    class Second: Product { }
    class Third : Product { }
    enum ProductEnumType {
        FIRST,SECOND,THIRD
    }

    class Creator {
        public virtual Product CreatProd(ProductEnumType type) {
            switch (type) {
                case ProductEnumType.FIRST:
                    return new First();
                case ProductEnumType.SECOND:
                    return new Second();
                default:
                    return null;
            }
        }
    }

    class MyCreator: Creator {
        public override Product CreatProd(ProductEnumType type) {
            if (type == ProductEnumType.THIRD)
                return new Third();
            return base.CreatProd(type);
        }
    }
    class Program {
        static void Main(string[] args) {

            Creator c1 = new Creator();
            c1.CreatProd(ProductEnumType.SECOND);
            c1 = new MyCreator();
            c1.CreatProd(ProductEnumType.THIRD);
            Console.ReadKey();
        }
    }
}

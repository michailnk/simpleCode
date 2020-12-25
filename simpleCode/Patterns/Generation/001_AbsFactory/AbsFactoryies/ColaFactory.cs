using ConsoleApp3.AbsProducts;
using ConsoleApp3.Products;

namespace ConsoleApp3.AbsFactoryies
{
    public class ColaFactory : AbsFactory {
        public override AbsBottle GetBottle() {
            return new BottleCola();
        }

        public override AbsWatter GetWatter() {
            return new WatterCola();
        }
    }
}

using ConsoleApp3.AbsProducts;
using ConsoleApp3.Products;
using ConsoleApp3.Products.BottlePepsics;

namespace ConsoleApp3.AbsFactoryies
{
    public class PepsiFactory : AbsFactory {
        public override AbsBottle GetBottle() => new BottlePepsi();
        public override AbsWatter GetWatter() => new WatterPepsi();
    }
}

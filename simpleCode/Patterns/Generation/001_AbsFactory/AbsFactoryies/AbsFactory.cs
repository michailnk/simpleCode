using ConsoleApp3.AbsProducts;

namespace ConsoleApp3.AbsFactoryies
{
    public abstract class AbsFactory
    {
        public abstract AbsBottle GetBottle();
        public abstract AbsWatter GetWatter();
    }
}

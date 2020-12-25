using ConsoleApp3.AbsFactoryies;
using ConsoleApp3.AbsProducts;

namespace ConsoleApp3.Client
{
    public class Client
    {
        AbsWatter watter;
        AbsBottle bottle;
        public Client(AbsFactory factoryies) {
            watter = factoryies.GetWatter();
            bottle = factoryies.GetBottle();
        }

        public void Interact() {
            bottle.Interact(watter);
        }
    }
}


namespace ConsoleApp3.AbsProducts
{
    public abstract class AbsBottle
    {
        public override string ToString() {
            return string.Format("Bottle {0} is created", GetType().Name);
        }

        public abstract void Interact(AbsWatter watter);
    }
}

using ConsoleApp3.AbsProducts;

namespace ConsoleApp3
{
    public abstract class AbsWatter
    {
        public override string ToString() {
            return string.Format("watter {0} is created", GetType().Name);
        }
    }
}

using ConsoleApp3.AbsProducts;

namespace ConsoleApp3
{
    public class BottleCola : AbsBottle {
        public override void Interact(AbsWatter watter) {
            System.Console.WriteLine($"this {watter.GetType().Name} in {this.GetType().Name}");
        }
    }
}

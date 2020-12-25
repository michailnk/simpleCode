using ConsoleApp3.AbsProducts;

namespace ConsoleApp3.Products
{
    public class BottlePepsi : AbsBottle {
        public override void Interact(AbsWatter watter) {
            System.Console.WriteLine($"this {watter.GetType().Name} in {this.GetType().Name}");
        }
    }
}

using System;

namespace Race {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Car";
            Console.SetWindowSize(100, 50);

            Console.CursorVisible = true;

            Game game = new Game();
            game.Run();

            Console.ReadKey();
        }
    }
}

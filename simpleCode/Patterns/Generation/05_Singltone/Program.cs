using System;

namespace Singltone {

    class MainWindow {
        private static MainWindow instance;
        private static object synRoot = new object();
        public String Name { get; private set; }
        protected MainWindow (string name) {
            this.Name = name;
        }

        public static MainWindow getInstance(string name) {
            if(instance == null) {
                lock (synRoot) {
                    if(instance == null) {
                        instance = new MainWindow(name);
                    }
                }
            }
            return instance;
        }

    }
    class Program {
        static void Main(string[] args) {
            MainWindow winow = MainWindow.getInstance("midle window");
            Console.WriteLine(winow.Name);
        }
    }
}

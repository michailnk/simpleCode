using System;
using System.Threading;

namespace Lazy2 {

    public class BigObject {
        private static BigObject instance = null;
        private BigObject() {
            Thread.Sleep(300);
            Console.WriteLine("instance BigObject created");
        }

        public static BigObject GetInstance() {
            if(instance == null) {
                lock (typeof(BigObject)) {
                    if(instance == null) {
                        instance = new BigObject();
                    }
                }
            }
            return instance;
        }
    }
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("first access to an instance BigObject");
            Console.WriteLine(BigObject.GetInstance() + " " + BigObject.GetInstance().GetHashCode()) ;
            Console.WriteLine("second access to an instance BigObject");
            Console.WriteLine(BigObject.GetInstance() + " " + BigObject.GetInstance().GetHashCode());
        }
    }
}

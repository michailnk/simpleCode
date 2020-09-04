using System;
using System.Collections;
namespace collection_001 {

    class UserCollection: IEnumerable, IEnumerator {
        Element[] elements = null;
        int position = -1;
        public UserCollection() {
            elements = new Element[4];
            elements[0] = new Element("A", 1, 10);
            elements[1] = new Element("B", 2, 20);
            elements[2] = new Element("C", 3, 30);
            elements[3] = new Element("D", 4, 40);
        }

        public object Current => elements[position];

        IEnumerator IEnumerable.GetEnumerator() => this as IEnumerator; 
        //public IEnumerator GetEnumerator() {
        //    throw new NotImplementedException();
        //}

        public bool MoveNext() {
            //return position++ < (elements.Length -1) ? true : false;
            if (position < elements.Length - 1) {
                position++;
                return true;
            }
            else {
                Reset();
                return false;
            }
        }

        public void Reset() {
            position = -1;
        }
    }
    class Program {
        static void Main(string[] args) {
            IEnumerable enumerable = new UserCollection();
            IEnumerator enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext()) {
                Element el = enumerator.Current as Element;
                Console.WriteLine( $" user: {el.Name} {el.Field1} {el.Field2}");
            }
            Console.WriteLine();
            // the same
            UserCollection col = new UserCollection();
            foreach (Element item in col) {
                Console.WriteLine($" user: {item.Name} {item.Field1} {item.Field2}");
            }
        }
    }

    class Element {
        private string name;
        private int field1;
        private int field2;

        public Element(string name, int field1, int field2) {
            this.name = name;
            this.field1 = field1;
            this.field2 = field2;
        }

        public string Name { get => name; set => name = value; }
        public int Field1 { get => field1; set => field1 = value; }
        public int Field2 { get => field2; set => field2 = value; }
    }
}

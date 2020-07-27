using System;

namespace _04_PrototypeClone {

    class Prototype {
        public String Class { get; set; }
        public String State { get; set; }
        public Prototype Clone() {
            return this.MemberwiseClone() as Prototype;
        }
    }
 
    class Program {
        static void Main(string[] args) {
            Prototype prototype = new Prototype();
            prototype.Class = "biology system";
            prototype.State = "";
            var Human = prototype.Clone() as Prototype;
            Human.Class = "person";
            Human.State = "general";

            var Man = Human.Clone();
            Man.Class = "man";
            Man.State = "male signs";
        }
    }
}

using System;

namespace Race {
    internal class Car {

        Engine engine;
        CarBody carBody;
        public Car(int left =44, int top=15) {

            engine = new Engine();
            carBody = new CarBody(left, top);
        }

        internal void Show() {
            carBody.Draw();
        }

        internal int Acceleration(int delta = 1) {
            return engine.Accelerate(delta);
        }

        public void Braking() {

        }
    }
}
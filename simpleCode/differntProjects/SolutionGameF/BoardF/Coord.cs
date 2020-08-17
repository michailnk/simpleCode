using System;
using System.Collections.Generic;

namespace BoardF {
    struct Coord {
        public int x;
        public int y;

        public Coord(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public Coord(int size) {
            x = size - 1;
            y = size - 1;
        }

        public Coord Add(int x, int y) {
            return new Coord(this.x + x, this.y + y);
        }
        public bool OnBoard(int size) {
            if (x < 0 || x > size - 1) return false;
            if (y < 0 || y > size - 1) return false;
            return true;
        }

        public IEnumerable<Coord> YieldCoord(int size) {
            for ( y = 0; y < size; y++) {
                for ( x = 0; x < size; x++) {
                    yield return this;
                }
            }
        }
    }
}

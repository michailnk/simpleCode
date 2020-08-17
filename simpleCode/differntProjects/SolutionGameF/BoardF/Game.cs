using System;

namespace BoardF {
    public class Game {
        int size;
        Map map;
        Coord space;

        public int moves { get; private set; }
        public Game(int size) {
            this.size = size;
            map = new Map(size);
        }

        public void Start(int seed = 0) {
            int digit = 0;
            foreach (Coord item in new Coord().YieldCoord(size)) 
                map.Set(item, ++digit);
                space = new Coord(size);

                if (seed > 0)
                    Shuffle(seed);
                moves = 0;
            
        }

        private void Shuffle(int seed) {
            Random random = new Random(seed);
            for (int i = 0; i < seed; i++) {
                PressAt(random.Next(size), random.Next(size));
            }
        }

        public int  PressAt(int x, int y) {

            return PressAt(new Coord(x, y));
        }
        int PressAt(Coord xy) {
            if (space.Equals(xy)) 
                return 0;
            if (xy.x != space.x && xy.y != space.y)
                return 0;
            
            int steps = Math.Abs(xy.x - space.x) +
                Math.Abs(xy.y - space.y);

            while (xy.x != space.x)
                Shift(Math.Sign(xy.x - space.x), 0);

            while (xy.y != space.y)
                Shift(0, Math.Sign(xy.y - space.y));

            moves += steps;
            return steps;

        }

        void Shift(int sx, int sy) {  
            Coord next = space.Add(sx, sy);

            map.Copy(next, space);
            space = next;
        }
        public int GetDigitAt(int x, int y) {
            return GetDigitAt(new Coord(x, y));
        }
        int GetDigitAt(Coord xy) {
            if (space.Equals(xy))
                return 0;
            return map.Get(xy);
        }
        public bool IsSolved() {

            if(!space.Equals(new Coord(size)))
            return false;

            int digit = 0;
            foreach (Coord xy in new Coord().YieldCoord(size))
                if (map.Get(xy) != ++digit)
                    return space.Equals(xy);
            return true;
        }
    }
}

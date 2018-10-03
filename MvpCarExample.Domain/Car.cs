using System;

namespace MvpCarExample.Domain
{
    public class Car
    {
        public float Angle { get; private set; }
        public int Speed { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public Car(int x, int y)
        {
            X = x;
            Y = y;
            Angle = 0;
            Speed = 0;
        }
    }
}

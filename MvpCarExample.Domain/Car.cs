using System;

namespace MvpCarExample.Domain
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class Car
    {
        public float Angle { get; private set; }
        public int Speed { get; private set; }
        public Vector Position { get; private set; }

        public void Move(float angle)
        {
            var radians = DegreeToRadian(angle);
            Position.X += Speed * Math.Cos(radians);
            Position.Y += Speed * Math.Sin(radians);
            Speed--;
        }

        public void Throttle(int throttle)
        {
            Speed += throttle;
        }

        public Car(int x, int y)
        {
            Position = new Vector();

            Angle = 0;
            Speed = 10;
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}

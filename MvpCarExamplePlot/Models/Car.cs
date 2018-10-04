using System;

namespace MvpCarExamplePlot.Models
{
    public class Car
    {
        public float Angle { get; private set; }
        public float Speed { get; private set; }
        public Vector Position { get; private set; }
        public float Friction { get; private set; }

        public void TurnRight(float angle)
        {
            Angle += angle;
        }

        public void TurnLeft(float angle)
        {
            Angle -= angle;
        }

        public void Forward()
        {
            var radians = DegreeToRadian(Angle);
            Position.X += Speed * Math.Sin(radians);
            Position.Y += Speed * Math.Cos(radians);
            Speed -= Friction;
        }

        public void Throttle(float throttle)
        {
            Speed += throttle;
        }

        public void Break()
        {
            Speed -= 2F;
        }

        public Car(int x, int y, float friction = 0.8F)
        {
            Position = new Vector { X = x, Y = y };

            Friction = friction;
            Angle = 0;
            Speed = 10;
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
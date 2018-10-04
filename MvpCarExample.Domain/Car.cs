using System;

namespace MvpCarExample.Domain
{
    public class Car
    {
        public float Angle { get; private set; }
        
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Speed { get; private set; }
        public bool EngineOn { get; private set; }

        public Car(int x, int y)
        {
            X = x;
            Y = y;
            Angle = 0;
            Speed = 0;
        }

        public void Accelarate()
        {
            this.Speed = this.Speed + 1;
        }
        public void Break()
        {
            this.Speed = this.Speed - 1;
        }

        public void Move(float _angel)
        {
            this.Angle = _angel;
            this.X += this.Speed * Convert.ToInt32(this.Angle);
            this.Y += this.Speed * Convert.ToInt32(this.Angle);

        }
        public void TurnOn()
        {
            this.EngineOn = true;
        }
        public void TurnOff()
        {
            this.EngineOn = false;
        }
    }


}

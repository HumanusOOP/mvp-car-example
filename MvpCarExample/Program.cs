using System;
using MvpCarExample.Domain;

namespace MvpCarExample
{
    partial class Program
    {
        private static string _consoleChars = "MyCarMvp>";
        private static readonly Car Car = new Car(0,0);
        

        static void Main(string[] args)
        {
            
            InternalConsole.Init();

            while (true)
            {
                Console.Write(_consoleChars);
                var line = Console.ReadLine();

                if (line == null)
                    continue;

                if (!string.IsNullOrWhiteSpace(line) && line.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
                    break;

                if (!string.IsNullOrWhiteSpace(line) && line.Trim().Equals("cls", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    continue;
                }

                if (line.Trim().Equals("car status", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"CAR STATUS");
                    Console.WriteLine($"EngineOn: {Car.EngineOn}");
                    Console.WriteLine($"Angle: {Car.Angle}");
                    Console.WriteLine($"Speed: {Car.Speed}");
                    Console.WriteLine($"X: {Car.X}");
                    Console.WriteLine($"Y: {Car.Y}");
                    Console.WriteLine($"");
                }

                if (line.Trim().Equals("car start", StringComparison.OrdinalIgnoreCase))
                {
                    Car.TurnOn();
                }
                if (line.Trim().Equals("car help", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("cmd you can use in this game");
                    Console.WriteLine("car start");
                    Console.WriteLine("car stop");
                    Console.WriteLine("car acc");
                    Console.WriteLine("car break");
                    Console.WriteLine("car move");
                }

                if (Car.EngineOn == false)
                {
                    Console.WriteLine("Engine is not on");
                }
                else
                {
                   
                    if (line.Trim().Equals("car stop", StringComparison.OrdinalIgnoreCase))
                    {
                        Car.TurnOff();
                    }
                    if (line.Trim().Equals("car acc", StringComparison.OrdinalIgnoreCase))
                    {
                        Car.Accelarate();
                    }
                    if (line.Trim().Equals("car break", StringComparison.OrdinalIgnoreCase))
                    {
                        Car.Break();
                    }
                    if (line.Trim().Equals("car move", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("enter angle:");

                        Car.Move(float.Parse(Console.ReadLine()));
                    }
                }
            }
        }
    }
}

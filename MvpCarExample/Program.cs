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
                    Console.WriteLine($"Angle: {Car.Angle}");
                    Console.WriteLine($"Speed: {Car.Speed}");
                    Console.WriteLine($"X: {Car.X}");
                    Console.WriteLine($"X: {Car.Y}");
                    Console.WriteLine($"");
                }

            }
        }
    }
}

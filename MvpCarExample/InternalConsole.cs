using System;

namespace MvpCarExample
{
    partial class Program
    {
        internal class InternalConsole
        {
            internal static void Init()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight / 2);
                Console.Clear();

                Console.WriteLine(@"");
                Console.WriteLine(@"███▄ ▄███▓ ██▒   █▓ ██▓███      ▄████▄   ▄▄▄       ██▀███  ");
                Console.WriteLine(@"▓██▒▀█▀ ██▒▓██░   █▒▓██░  ██▒   ▒██▀ ▀█  ▒████▄    ▓██ ▒ ██▒");
                Console.WriteLine(@"▓██    ▓██░ ▓██  █▒░▓██░ ██▓▒   ▒▓█    ▄ ▒██  ▀█▄  ▓██ ░▄█ ▒");
                Console.WriteLine(@"▒██    ▒██   ▒██ █░░▒██▄█▓▒ ▒   ▒▓▓▄ ▄██▒░██▄▄▄▄██ ▒██▀▀█▄  ");
                Console.WriteLine(@"▒██▒   ░██▒   ▒▀█░  ▒██▒ ░  ░   ▒ ▓███▀ ░ ▓█   ▓██▒░██▓ ▒██▒");
                Console.WriteLine(@"░ ▒░   ░  ░   ░ ▐░  ▒▓▒░ ░  ░   ░ ░▒ ▒  ░ ▒▒   ▓▒█░░ ▒▓ ░▒▓░");
                Console.WriteLine(@"░  ░      ░   ░ ░░  ░▒ ░          ░  ▒     ▒   ▒▒ ░  ░▒ ░ ▒░");
                Console.WriteLine(@"░      ░        ░░  ░░          ░          ░   ▒     ░░   ░ ");
                Console.WriteLine(@"       ░         ░              ░ ░            ░  ░   ░     ");
                Console.WriteLine(@"                ░               ░                           ");
                Console.WriteLine();
                Console.WriteLine($"Advanced OOP - Class of 2018 :]");
                Console.WriteLine("                                                   Type quit to exit.");
                Console.WriteLine("");

                Console.WriteLine("Type: 'car command <-param value>' to interact, example: car turn -degrees 45, car forward -speed 10, car reverse -speed 10)");
                Console.WriteLine("Type: 'car status' to describe where the Car is now and where it is headed");
                Console.WriteLine("");
            }
        }
    }
}

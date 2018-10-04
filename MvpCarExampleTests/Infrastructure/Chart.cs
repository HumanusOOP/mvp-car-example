using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using MvpCarExample.Domain;

namespace MvpCarExampleTests.Infrastructure
{
    public class Chart
    {
        public static void Plot(List<Vector> vectors)
        {
            foreach (var vector in vectors)
            {
                for (var y = -100; y < 100; y++)
                {
                    Debug.Write($"{y} ");
                    for (var x = -100; x < 100; x++)
                    {
                        if (x == (int)Math.Round(vector.X) && y == (int)Math.Round(vector.Y))
                            Debug.Write("*");
                        else
                            Debug.Write("-");
                    }

                    Debug.WriteLine("");
                }
                Debug.WriteLine("");
                Thread.Sleep(100);
            }
        }
    }
}

using System;
using System.Threading;

namespace _4task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 8, y = 2;
            if(x * y < 1)
            {
                Thread thread = new Thread(() => First(x, y));
                thread.Start();
            }else if(x * y >= 1 && x * y <= 8)
            {
                Thread thread = new Thread(() => Second(x, y));
                thread.Start();
            }
            else
            {
                Thread thread = new Thread(() => Third(x, y));
                thread.Start();
            }
            Console.ReadKey();
        }

        static void First(int x, int y)
        {
            Console.WriteLine( (float)(x + y) / (1 - x * y));
        }
        static void Second(int x, int y)
        {
            Console.WriteLine(Math.Sqrt(Math.Abs(Math.Pow(x, 3) + Math.Pow(y, 3))));
        }
        static void Third(int x, int y)
        {
            Console.WriteLine((float)(x + y) / (12 + x + x * y));
        }
    }
}

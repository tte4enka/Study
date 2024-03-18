using System;

namespace _3task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            L<double> l = new L<double>();
            Console.Write($"{l.Sum(2, 7, -2):f3}");

            Console.ReadKey();
        }
    }
}

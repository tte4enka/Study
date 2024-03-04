using System;

namespace _1task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();

            Console.WriteLine($"2 + 6 = {calculate.add(2,6)}");
            Console.WriteLine($"2 - 6 = {calculate.subtract(2,6)}");
            Console.WriteLine($"2 * 6 = {calculate.multiply(2,6)}");
            Console.WriteLine($"2 / 6 = {calculate.divide(2,6)}");
            Console.WriteLine($"sqrt(4) = {calculate.sqrt(4)}");
            Console.WriteLine($"|-4| = {calculate.abs(-4)}");
            Console.WriteLine($"4 ^ 2 = {calculate.pow(4, 2)}");
            Console.ReadKey();
        }
    }
}

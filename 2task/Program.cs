using System;

namespace _2task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xn = -6;
            double xk = 6;
            double dX = 0.6;
            Calculator calc = new Calculator(); 
            for (double i = xn;  i <= xk; i+= dX) 
            {
                Console.WriteLine($"При х = {i:f2}, z = {calc.Calculate(i):f2} ");
            }
            Console.ReadKey();
        }
    }
}

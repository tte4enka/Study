using System;

namespace _1task
{
    public class Calculate : IArithmetic
    {
        public double add(double x, double y)
        {
            return x + y;
        }
        public double subtract(double x, double y)
        {
            return x - y;
        }
        public double multiply(double x, double y)
        {
            return x * y;
        }
        public double divide(double x, double y)
        {
            return x / y;
        }
        public double sqrt(double x)
        {
            return Math.Sqrt(x);
        }
        public double abs(double x)
        {
            return Math.Abs(x);
        }
        public double pow(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}

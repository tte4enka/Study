using System;

namespace _3task
{
    public class L<T> where T : struct, IConvertible
    {
        public double Sum(T g, T x, T z)
        {
            double gValue = Convert.ToDouble(g);
            double xValue = Convert.ToDouble(x);
            double zValue = Convert.ToDouble(z);

            return Math.Pow(gValue, 1 / 7f) * Math.Cos(xValue * xValue * xValue) + Math.Atan(xValue - zValue);
        }
    }
}

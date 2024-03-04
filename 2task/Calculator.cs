using System;

namespace _2task
{
    public class Calculator : ICalculator
    {
        public double Calculate(double x)
        {
            if(x > 4)
            {
                return Math.Log(x * x + 2) - x * x * x;
            }else if(x <=4 && x >= -4)
            {
                return Math.Pow(Math.Asin(0.2), 2);
            }
            else
            {
                return Math.Sqrt(Math.Abs(x + 1));
            }
        }
    }
}

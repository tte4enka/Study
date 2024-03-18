using System;

namespace Task4
{
    public class Program
    {
        delegate T SumDelegate<T>(T a, T b);
        delegate T DifferenceDelegate<T>(T a, T b);

        static void Main(string[] args)
        {
            SumDelegate<int> sumInt = (a, b) => a + b;
            SumDelegate<double> sumDouble = (a, b) => a + b;
            SumDelegate<string> sumString = (a, b) => a + b;

            DifferenceDelegate<int> diffInt = (a, b) => a - b;
            DifferenceDelegate<double> diffDouble = (a, b) => a - b;
            DifferenceDelegate<string> diffString = (a, b) => a.Replace(b, "");

            Console.WriteLine($"Сумма 5 и 3 (int): {sumInt(5, 3)}");
            Console.WriteLine($"Сумма 5.5 и 3.2 (double): {sumDouble(5.5, 3.2)}");
            Console.WriteLine($"Сумма 'Hello' и ' World' (string): {sumString("Hello", " World")}");

            Console.WriteLine($"Разность 10 и 7 (int): {diffInt(10, 7)}");
            Console.WriteLine($"Разность 8.5 и 3.2 (double): {diffDouble(8.5, 3.2)}");
            Console.WriteLine($"Разность 'Programming' и 'ing' (string): {diffString("Programming", "ing")}");
        }
    }
}

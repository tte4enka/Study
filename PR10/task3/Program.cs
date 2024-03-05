using System;

namespace _3task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cellular cellular = new Cellular("Samsung", 999999999, "s22", 2100);
            Landline landline = new Landline("Apple", 1, Mobility.portable);

            Console.WriteLine($"cellur cost = {cellular.Cost():f3}BYN\nlandline cost = {landline.Cost():f3}BYN");
            Console.ReadKey();
        }
    }
}

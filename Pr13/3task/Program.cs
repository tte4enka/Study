using System;

namespace _3task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buyer a = new Buyer(150);
            Buyer b = new Buyer(2000);

            SuperMarket market = new SuperMarket();

            market.RaiseOnBuyerJoin(a);
            market.RaiseOnBuyerJoin(b);

            Console.ReadKey();
        }
    }
}

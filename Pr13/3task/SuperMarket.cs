using System;
using System.Collections;

namespace _3task
{
    public class SuperMarket
    {
        private double _cash;

        public double Cash { get => _cash; set => _cash = value; }

        public delegate void EventHandler(Buyer buyer);
        public event EventHandler _onBuyerJoin;

        public SuperMarket()
        {
            _onBuyerJoin += BuyerJoin;
        }
        public void RaiseOnBuyerJoin(Buyer b)
        {
            _onBuyerJoin(b);
        }
        public void BuyerJoin(Buyer buyer)
        {
            buyer.AddItems();
            buyer.Buy();
            _cash += buyer.CartSum;
            Console.WriteLine($"Магазин заработал: {_cash}");
        }

    }
}

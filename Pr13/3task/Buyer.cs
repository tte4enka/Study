using System;

namespace _3task
{
    public class Buyer
    {
        private double _money;
        private double[] _cart;

        public Buyer()
        {
        }

        public Buyer(double money)
        {
            Money = money;
        }

        public double Money { get => _money; set => _money = value; }
        public double[] Cart { get => _cart; set => _cart = value; }
    }
}

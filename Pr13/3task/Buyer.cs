using System;
using System.Collections.Generic;
using System.Net;

namespace _3task
{
    public class Buyer
    {
        private double _money;
        private List<double> _cart = new List<double>();
        private double _cartSum;

        public Buyer(double money)
        {
            Money = money;
        }

        public double Money { get => _money; set => _money = value; }
        public List<double> Cart { get => _cart; set => _cart = value; }
        public double CartSum { get => _cartSum; set => _cartSum = value; }

        public void AddItems()
        {
            Random random = new Random();
            for(int i = 0; i < random.Next(2, 10); i++)
            {
                _cart.Add(random.Next(10, 150));
            }
            foreach (var item in _cart)
            {
                _cartSum += item;
            }
        }
        public void Buy()
        {
            Random random = new Random();
            while(_money < _cartSum) 
            {
                if (_cartSum <= _money)
                {
                    _money -= _cartSum;
                    break;
                }
                _cartSum = 0;
                foreach (var item in _cart)
                {
                    _cartSum += item;
                }
                if (_cartSum > _money)
                {
                    _cart.RemoveAt(random.Next(_cart.Count));
                }
            }
        }
    }
}

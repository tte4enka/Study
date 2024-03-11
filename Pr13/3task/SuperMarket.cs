using System;
using System.Collections;

namespace _3task
{
    public class SuperMarket
    {
        private Queue _queue;

        public SuperMarket()
        {
        }

        public SuperMarket(Queue queue)
        {
            Queue = queue;
        }

        public Queue Queue { get => _queue; set => _queue = value; }
    }
}

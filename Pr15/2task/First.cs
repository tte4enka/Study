using System;

namespace _2task
{
    public class First<T> where T: Name
    {
        public T Value { get; set; }

        public First(T Value) 
        {
            this.Value = Value;
        }

        public void FirstDisplay()
        {
            Console.WriteLine($"Имя: {Value.name}");
        }
    }
}

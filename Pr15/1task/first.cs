using System;
using System.Security.Cryptography;

namespace _1task
{
    public class First<T>
    {
        T name {  get; set; }
        public First(T name) 
        {
            this.name = name;
        }
        public void FirstDisplay() 
        {
           Console.WriteLine($"Имя: {name}");
        }

    }
}

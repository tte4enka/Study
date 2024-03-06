using System;

namespace _3task
{
    public class Phone
    {
        private string brand;
        private int functionCount;

        public Phone()
        {
            brand = "None";
            functionCount = 1;
        }
        public Phone(string brand, int funcC)
        {
            this.brand = brand;
            this.functionCount = funcC;
        }
        public virtual string _brand { get; set; }
        public virtual int _functionCount { get; set; }

        public virtual double Cost()
        {
            return 40 * Math.Log(functionCount);
        }
        public virtual void Display()
        {
            Console.WriteLine($"Марка телефона: {brand}\nКоличество функций: {functionCount}");
        }
    }
}

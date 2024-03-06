using System;

namespace _3task
{
    public abstract class Phone
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
        public string _brand { get; set; }
        public int _functionCount { get; set; }

        public virtual double Cost()
        {
            return 40 * Math.Log(functionCount);
        }
    }
}

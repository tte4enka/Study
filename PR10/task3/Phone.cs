using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int _functionCount {  get; set; }

        public virtual double Cost(int k)
        {
            return 40 * Math.Log(k);
        }
    }
}

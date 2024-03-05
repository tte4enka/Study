using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3task
{
    public  class Cellular : Phone
    {
        private string model;
        private int year;
        public Cellular(): base() 
        {
            model = string.Empty;
            year = 0;
        }
        public Cellular(string model, int year, string brand, int functionCount): base(brand, functionCount)
        {
            this.model = model;
            this.year = year;
        }
        public string Model {  get { return model; } }
        public int Year { get { return year; } }

        public override double Cost(int k)
        {
            if (this.Year > DateTime.Now.Year - 1)
                return base.Cost(k) * 1.2;
            else if (this.Year < DateTime.Now.Year - 3)
                return base.Cost(k) - (base.Cost(k) * 0.6);
            return base.Cost(k);
        }
    }
}

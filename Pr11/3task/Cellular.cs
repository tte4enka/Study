using System;

namespace _3task
{
    public class Cellular : Phone
    {
        private string model;
        private int year;
        public Cellular() : base()
        {
            model = string.Empty;
            year = 0;
        }
        public Cellular(string brand, int functionCount, string model, int year) : base(brand, functionCount)
        {
            this.model = model;
            this.year = year;
        }
        public string Model { get { return model; } }
        public int Year { get { return year; } }

        public override double Cost()
        {
            if (this.Year > DateTime.Now.Year - 1)
                return base.Cost() * 1.2;
            else if (this.Year < DateTime.Now.Year - 3)
                return base.Cost() - (base.Cost() * 0.6);
            return base.Cost();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Модель: {model}\nГод выпуска:{year}");
        }
    }
}

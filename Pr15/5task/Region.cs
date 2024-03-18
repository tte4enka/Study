using System;

namespace _2task
{
    public sealed class Region : Place<string>
    {
        private string NameOfRegion;
        public string nameOfRegion { get; private set; }

        public Region()
        {
            this.NameOfRegion = null;
        }

        public Region(string Continent, string nameOfRegion) : base(Continent)
        {
            this.NameOfRegion = nameOfRegion;
        }

        public override void GetPlace()
        {
            base.GetPlace();
            Console.WriteLine($"Область: {NameOfRegion}");
        }

        public override void ChangePlace()
        {
            Console.Write("Введети континент для изменения:");
            continent = Console.ReadLine();
            Console.Write("Введите название области для изменения:");
            nameOfRegion = Console.ReadLine();
        }
        public void ChangeName(string a)
        {
            NameOfRegion = a;
        }

    }

}
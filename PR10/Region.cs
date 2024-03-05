using System;

namespace _1task
{
    public class Region : Place
    {
        private string NameOfRegion;
        public string nameOfRegion {  get; private set; }

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
            Console.WriteLine($"Область: {NameOfRegion} распологается на континенте {continent}");
        }

        public override void ChangePlace()
        {
            Console.Write("Введети континент для изменения:");
            nameOfRegion = Console.ReadLine();
            Console.Write("Введите название области для изменения:");
            continent = Console.ReadLine();
        }
        public void ChangeName(string a)
        {
            NameOfRegion = a;
        }

    }

}

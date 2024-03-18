using System;

namespace _2task
{
    public class Metropolis : Place<string>
    {
        private string NameOfMetropolis;

        public Metropolis()
        {
            this.NameOfMetropolis = null;
        }

        public Metropolis(string Continent, string nameOfRegion) : base(Continent)
        {
            this.NameOfMetropolis = nameOfRegion;
        }

        public override void GetPlace()
        {
            base.GetPlace();
            Console.WriteLine($"Мегаполис: {NameOfMetropolis}");
        }
        public override void ChangePlace()
        {
            Console.Write("Введети континент для изменения:");
            continent = Console.ReadLine();
            Console.Write("Введите название дял изменения:");
            NameOfMetropolis = Console.ReadLine();
        }

        public void ChangeName(string name)
        {
            NameOfMetropolis = name;
        }

    }

}
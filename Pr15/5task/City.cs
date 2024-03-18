using System;
using System.Diagnostics;

namespace _2task
{
    public class City : Place<string>
    {
        private string NameOfCity;
        private long CountPeople;

        public City()
        {
            this.NameOfCity = null;
        }

        public City(string Continent, string nameOfRegion, long Countpeople) : base(Continent)
        {
            this.NameOfCity = nameOfRegion;
            this.CountPeople = Countpeople;
        }

        public override void GetPlace()
        {
            base.GetPlace();
            Console.WriteLine($"Город: {NameOfCity}, в нем живет {CountPeople} людей");
        }
        public override void ChangePlace()
        {
            Console.Write("Введите континент для изменения:");
            continent = Console.ReadLine();
            Console.Write("Введите название города для изменения:");
            NameOfCity = Console.ReadLine();
            Console.Write("Введите количество людей для изменения:");
            CountPeople = long.Parse(Console.ReadLine());
        }
        public void SetNameOfCity(string name)
        {
            NameOfCity = name;
        }
        public void SetCountPeople(long count)
        {
            CountPeople = count;
        }

    }

}
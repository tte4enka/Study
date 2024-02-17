using System;
using System.Collections;
/*
 Задание 1. Написать программу, в которой создаются объекты различных классов и
помещаются в массив, после чего массив просматривается.
Каждый разрабатываемый класс должен содержать следующие элементы:
скрытые поля, конструкторы с параметрами и без параметров, методы; свойства, индексаторы;
перегруженные операции. Функциональные элементы класса должны обеспечивать
непротиворечивый, полный, минимальный и удобный интерфейс класса.
Использовать для хранения экземпляров разработанных классов стандартные
параметризованные коллекции. Во всех классах реализовать интерфейс IComparable и
перегрузить операции отношения для реализации значимой семантики сравнения объектов по
какому-либо полю на усмотрение студента.

8) Место, область, город, мегаполис

Задание 2. Для классов, разработанных в задании 1, реализовать работу со следующей
обобщенной коллекцией: Очередь.
*/

namespace ConsoleApp1
{
    public abstract class Place : IComparable
    {
        private string _continent;

        public Place()
        {
            _continent = "None";
        }

        public Place(string continent)
        {
            _continent = continent;
        }
        public string Continent { get { return _continent; } }

        public abstract void GetInfo();
        int IComparable.CompareTo(object obj)
        {
            Place otherPlace = (Place)obj;
            return String.Compare(this._continent, otherPlace._continent);
        }
    }
    public class Region : Place
    {
        private string NameOfRegion;

        public Region()
        {
            this.NameOfRegion = null;
        }

        public Region(string Continent, string nameOfRegion) : base(Continent)
        {
            this.NameOfRegion = nameOfRegion;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Область: {NameOfRegion} распологается на континенте {Continent}");
        }
    }
    public class City : Place
    {
        private string _nameOfCity;
        private long _countPeople;

        public City()
        {
            this._nameOfCity = null;
        }

        public City(string Continent, string nameOfRegion, long Countpeople) : base(Continent)
        {
            this._nameOfCity = nameOfRegion;
            this._countPeople = Countpeople;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Город: {_nameOfCity} распологается на континенте {Continent}, в нем живет {_countPeople} людей");
        }
    }
    public class Metropolis : Place
    {
        private string _nameOfMetropolis;

        public Metropolis()
        {
            this._nameOfMetropolis = null;
        }

        public Metropolis(string Continent, string nameOfRegion) : base(Continent)
        {
            this._nameOfMetropolis = nameOfRegion;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Мегаполис: {_nameOfMetropolis} распологается на континенте {Continent}");
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Place[] places = new Place[4];
            Region gomelsk = new Region("Африка", "Гомельская");
            Region pinsk = new Region("Северная Америка", "Пинская");
            City gomel = new City("Евразия", "Гомель", 200000000);
            Metropolis moskva = new Metropolis("Южная Америка", "Москва");
            places[0] = gomelsk; places[1] = pinsk; places[2] = gomel; places[3] = moskva;
            list.AddRange(places);
            Console.WriteLine("До сортировки:");
            foreach (Place obj in list)
            {
                obj.GetInfo();
            }
            list.Sort();
            Console.WriteLine("\n\n\nПосле сортировки:");
            foreach (Place obj in list)
            {
                obj.GetInfo();
            }

            Console.ReadKey();
        }
    }
}

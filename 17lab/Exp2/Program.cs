using System;
using System.Collections.Generic;
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
            Queue<Place> places = new Queue<Place>();

            bool isActive = true;
            while (isActive)
            {
                Console.WriteLine("---Menu---");
                Console.WriteLine("1 - заполнить очередь базовыми значениями.");
                Console.WriteLine("2 - добавить элемент.");
                Console.WriteLine("3 - извлечь и вывести первый элемент.");
                Console.WriteLine("4 - просмотреть первый элемент");
                Console.WriteLine("5 - выход");
                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Region pinsk = new Region("Северная Америка", "Пинская");
                            City gomel = new City("Евразия", "Гомель", 200000000);
                            Metropolis moskva = new Metropolis("Южная Америка", "Москва");
                            places.Enqueue(pinsk);
                            places.Enqueue(gomel);
                            places.Enqueue(moskva);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("---Add Menu---\n" +
                                "1 - регион\n" + "2 - город\n" + "3 - мегаполис");
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    Console.Write("Введите континент:");
                                    string cont = Console.ReadLine();
                                    Console.Write("Введите название региона:");
                                    string name = Console.ReadLine();
                                    places.Enqueue(new Region(cont, name));
                                    Console.Clear();
                                    Console.WriteLine("Регион успешно добавлен!");
                                    break;
                                case 2:
                                    Console.Write("Введите континент:");
                                    cont = Console.ReadLine();
                                    Console.Write("Введите название города:");
                                    name = Console.ReadLine();
                                    Console.Write("Введите кол-во людей живущих в городе:");
                                    long count = long.Parse(Console.ReadLine());
                                    places.Enqueue(new City(cont, name, count));
                                    Console.Clear();
                                    Console.WriteLine("Город успешно добавлен!");
                                    break;
                                case 3:
                                    Console.Write("Введите континент:");
                                    cont = Console.ReadLine();
                                    Console.Write("Введите название мегаполиса:");
                                    name = Console.ReadLine();
                                    places.Enqueue(new Metropolis(cont, name));
                                    Console.Clear();
                                    Console.WriteLine("Мегаполис успешно добавлен!");
                                    break;
                            }
                            break;
                        case 3:
                            if(places.Count != 0)
                            {
                                Place a = places.Dequeue();
                                a.GetInfo();
                            }
                            else
                            {
                                Console.WriteLine("Очередь пуста!");
                            }
                            break;
                        case 4:
                            if (places.Count != 0)
                            {
                                Place a = places.Peek();
                                a.GetInfo();
                            }
                            else
                            {
                                Console.WriteLine("Очередь пуста!");
                            }
                            break;
                        case 5:
                            isActive = false;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Вы ввели что-то неверно!");
                }
            }
        }
    }
}
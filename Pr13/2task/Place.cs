using System;

namespace _2task
{
    public class Place
    {
        private delegate void EventHandler();
        private event EventHandler _onCreate;
        private event EventHandler _onDisplay;
        private string Continent;
        public string continent { get { return Continent; } set { } }

        public Place(string continent)
        {
            Continent = continent;
            _onCreate += OnCreate;
            _onCreate();
            _onDisplay += OnDisplay;
        }

        public Place()
        {
            Continent = "Африка";
            _onCreate += OnCreate;
            _onCreate();
            _onDisplay += OnDisplay;
        }
        public virtual void GetPlace()
        {
            _onDisplay();
            Console.WriteLine($"Место расположено на континенте:{Continent}");
        }
        public virtual void ChangePlace()
        {
            Console.Write("Введите континент для изменения:");
            Continent = Console.ReadLine();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Place temp = (Place)obj;
            return Continent == temp.Continent;
        }

        private void OnCreate()
        {
            Console.WriteLine($"Объект класса {this} создан");
        }

        private void OnDisplay()
        {
            Console.WriteLine($"Объект успешно выведен");
        }
    }

}
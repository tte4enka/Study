using System;

namespace _2task
{
    public class Place<T> 
    {
        private delegate void EventHandler();
        private event EventHandler _onCreate;
        private event EventHandler _onDisplay;
        private T Continent;
        public T continent { get { return Continent; } set { } }

        public Place(T continent)
        {
            Continent = continent;
            _onCreate += OnCreate;
            _onCreate();
            _onDisplay += OnDisplay;
        }

        public Place()
        {
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
using System;

namespace _1task
{
    public class Place
    {
        private string Continent;
        public string continent { get { return Continent; } set { } }

        public Place(string continent)
        {
            Continent = continent;
        }

        public Place()
        {
            Continent = "Африка";
        }
        public virtual void GetPlace()
        {
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
    }

}
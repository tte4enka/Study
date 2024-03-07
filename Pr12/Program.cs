using System;

namespace _1task
{
    internal class Program
    {
        delegate void GetAll();
        delegate void ChangeAll();
        static void Main(string[] args)
        {
            Region region = new Region("Африка", "Гомельская область");
            City city = new City("Африка", "Гомель", 1888888);
            Metropolis metropolis = new Metropolis("Африка", "Москва");

            GetAll get = () =>
            {
                region.GetPlace();
                city.GetPlace();
                metropolis.GetPlace();
            };
            get.Invoke();

            ChangeAll change = () =>
            {
                region.ChangePlace();
                city.ChangePlace();
                metropolis.ChangePlace();
            };
            get.Invoke();

            Console.ReadKey();
        }
    }
}
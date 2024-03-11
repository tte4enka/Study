using System;

namespace _2task
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
            
            Console.WriteLine();
            region.GetPlace();
            Console.WriteLine();
            city.GetPlace();
            Console.WriteLine();
            metropolis.GetPlace();
            

            Console.ReadKey();
        }
    }
}
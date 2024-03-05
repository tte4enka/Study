using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Region region = new Region("Африка", "Гомельская область");
            region.ChangePlace();
            region.ChangeName("Гомельская");
            region.GetPlace();

            City city = new City("Африка", "Гомель", 1888888);
            city.GetPlace();
            city.SetNameOfCity("Минск");
            city.ChangePlace();
            city.SetCountPeople(10);

            Metropolis metropolis = new Metropolis("Африка", "Москва");
            metropolis.ChangePlace();
            metropolis.ChangeName("НеМосква");
            metropolis.GetPlace();
        }
    }
}

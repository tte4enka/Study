using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(1, 3, 2026);
            Date date2 = new Date(1, 3, 2024);

            Console.WriteLine(date2 == date1);
            Console.WriteLine(date1 > date2);

            Console.ReadLine();
        }
    }
}

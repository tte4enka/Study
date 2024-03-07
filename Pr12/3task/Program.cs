using System;

namespace _3task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assistant assistant = new Assistant();
            Manager manager = new Manager();

            assistant.Add();
            manager.Add();

            Console.ReadKey();
        }
    }
}

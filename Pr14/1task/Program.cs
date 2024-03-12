using System;
using System.Threading;
/*
 Создайте многопоточное приложение. В одном потоке выводите первую букву вашего имени, во втором потоке выводите первую букву вашей фамилии.
 */
namespace _1task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread first = new Thread(() => { Console.WriteLine("И"); });
            Thread second = new Thread(() => { Console.WriteLine("Г"); });

            first.Start();
            second.Start();

            Console.ReadKey();
        }
    }
}

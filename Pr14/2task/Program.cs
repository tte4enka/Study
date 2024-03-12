using System;
using System.Threading;
/*
 Создайте многопоточное приложение. Создайте 10 потоков, в каждом из которых, 
организуйте вывод чисел от 1 до 10 и вывод информации о том, какой из потоков сейчас работает.
 */
namespace _2task
{
    internal class Program
    {
        public static void OneToTen()
        {
            for(int i = 1; i < 11; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            for( int i = 1;i < 11;i++)
            {
                Console.Write($"Поток номер {i}:");
                Thread thread = new Thread(OneToTen);
                Thread.Sleep(400);
                thread.Start();
                Thread.Sleep(400);
            }
            Console.ReadKey();
        }
    }
}

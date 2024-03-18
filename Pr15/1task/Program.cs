using System;

/*
 Создайте консольное приложение. В нем создайте два обобщенных класса: 
один – с одним параметром, который будет выводить ваше имя, 
второй – с тремя параметрами, который будет выводить имя, фамилию и возраст.
 */

namespace _1task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            First<string> first = new First<string>("Иван");
            first.FirstDisplay();
            Second<string, int> second = new Second<string, int>("Иван", "Герасимов", 17);
            second.SecondDisplay();

            Console.ReadKey();
        }
    }
}

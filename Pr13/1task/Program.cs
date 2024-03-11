using System;

namespace _1task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student("Смирнов", "Олег"),
                new Student("Кузнецов", "Евгений"),
                new Student("Матвеенко", "Алексей"),
                new Student("Квадрат", "Михаил"),
                new Student("Маленький", "Вадим")
            };

            Random random = new Random();

            students[random.Next(0, 4)].OnCall();

            Console.ReadKey();
        }
    }
}

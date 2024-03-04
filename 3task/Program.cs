using System;

namespace _3task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TRAIN[] trains = new TRAIN[6];


            Console.WriteLine("Введите данные о поездах:");

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Поезд {i + 1}:");
                Console.Write("Название пункта назначения: ");
                string destination = Console.ReadLine();
                Console.Write("Номер поезда: ");
                int trainNumber = int.Parse(Console.ReadLine());
                Console.Write("Время отправления (в формате дд/мм/гггг чч:мм): ");
                DateTime departureTime = DateTime.Parse(Console.ReadLine());

                trains[i] = new TRAIN(destination, trainNumber, departureTime);
            }
            Console.Clear();
            Console.WriteLine("До:");
            foreach (var train in trains)
            {
                Console.WriteLine($"Номер поезда: {train.TrainNumber}, Время отправления: {train.DepartureTime}");
            }
            Array.Sort(trains);
            Console.WriteLine("После:");
            foreach (var train in trains)
            {
                Console.WriteLine($"Номер поезда: {train.TrainNumber}, Время отправления: {train.DepartureTime}");
            }
            Console.Write("Введите название пункта назначения для поиска: ");
            string searchDestination = Console.ReadLine();

            bool found = false;

            Console.WriteLine("Поезда, направляющиеся в " + searchDestination + ":");

            foreach (var train in trains)
            {
                if (train.Destination == searchDestination)
                {
                    Console.WriteLine($"Номер поезда: {train.TrainNumber}, Время отправления: {train.DepartureTime}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Поездов, направляющихся в указанный пункт назначения, не найдено.");
            }

            Console.ReadLine();
        }
    }
}

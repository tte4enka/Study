using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thisThread = Thread.CurrentThread;
            Console.WriteLine($"Имя домена приложения: {Thread.GetDomain()}ID контекста: {thisThread.ManagedThreadId}\nИмя потока: {thisThread.Name}\nЗапущен ли поток: {thisThread.IsAlive}\nПриоритет потока: {thisThread.Priority}\nСостояние: {thisThread.ThreadState} ");
            Console.ReadKey();
        }
    }
}

using System;
using System.Runtime.InteropServices;
using System.Threading;

/*
 Создайте многопоточное приложение. В нем создайте поток, который будет выводить число пи.
Вывод должен осуществляться только 1000+ n*10, где n – ваш вариант, затем должно произойти прерывание работы потока.
 */
namespace _3task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread piThread = new Thread(PiWrite);
            
            piThread.Start();
            

            Console.ReadKey();
        }

        static void PiWrite()
        {
            string pi = Convert.ToString(Math.PI);
            for(int i = 2; i < pi.Length; i++) 
            {
                Thread.Sleep(1000 + 8 * 10);
                Console.Write(pi[i] + " ");  
            }
        }
    }
}

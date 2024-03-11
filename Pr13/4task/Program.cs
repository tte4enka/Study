using System;
using System.Runtime.InteropServices;

namespace _4task
{
    internal class Program
    {
        public static event Action _event;
        public static event Action _closeEvent;

        public static void Mistake()
        {
            Console.WriteLine("Вы ввели неверный пароль!!!");
        }
        
        public static void Error()
        {
            Console.WriteLine("Вы 3 раза ввели неверный пароль! X_X");
        }
        static void Main(string[] args)
        {
            string _password = "12345678";
            string _secretMessage = "Засекречено";
            int _count = 0;

            _event += Mistake;
            _closeEvent += Error;

            while (true)
            {
                string _userInput = Console.ReadLine();
                _count++;
                if (_userInput == _password)
                {
                    Console.WriteLine(_secretMessage);
                    break;
                }
                if(_count < 3 && _userInput != _password)
                {
                    _event();
                }
                else
                {
                    _closeEvent();
                    Console.ReadKey();
                    return;
                }
            }
            Console.ReadKey();


        }
    }
}

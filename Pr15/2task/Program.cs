using System;

/*
 Создайте консольное приложение. В приложении из задания 1 модифицируйте класс 
с одним параметром, сделайте его ограниченным.
Для этого создайте новый класс, который будет ограничивать исходный. 
 */

namespace _2task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name name = new Name("Иван");
            First<Name> first = new First<Name>(name);

            first.FirstDisplay();
            Console.ReadKey();
        }
    }
}

using System;

namespace _1task
{
    public class Second<T, L>
    {
        T name {  get; set; }
        T surname { get; set; }
        L old {  get; set; }

        public Second(T name, T surname, L old)
        {
            this.name = name;
            this.surname = surname;
            this.old = old;
        }
        public void SecondDisplay()
        {
            Console.WriteLine($"Имя: {name}, Фамилия: {surname}, возраст: {old}");
        }
    }
}

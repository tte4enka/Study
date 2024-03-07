using System;

/*
 Класс человек «Person» - включает следующие свойства – Имя (Name),
Фамилию (Fio) и оклад (Salary);
 */
namespace _3task
{
    public class Person
    {
        private string name;
        private string fio;
        private double salary;

        public Person()
        {
            name = "Unknown";
            fio = "Unknown";
            salary = 0;
        }

        public Person(string name, string fio, long salary)
        {
            this.name = name;
            this.fio = fio;
            this.salary = salary;
        }
        public string _name { get { return name; } }
        public string _fio { get {  return fio; } }
        public double _salary { get {  return salary; } }
    }
}

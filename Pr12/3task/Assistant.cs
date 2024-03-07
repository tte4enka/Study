using System;
using System.Xml.Linq;
/*
 Класс продавец «Assistant» - наследник класса «Person», содержит все
свойства родительского класса, а также и дополнительные свойства Стаж
(Seniority)  и Зарплата (Salarysum).  Зарплата рассчитывается как  оклад плюс
стаж умноженный на 2% (Salarysum =Salary+ Seniority*0.2);
*/
namespace _3task
{
    public class Assistant : Person
    {
        delegate void AddHandler();
        event AddHandler Notify;
        private double seniority;
        private double salarysum;

        public Assistant(): base()
        {
            seniority = 0;
            salarysum = 0;
            Notify += Add;
        }

        public Assistant(string name, string fio, long salary, long seniority, long salarysum): base(name, fio, salary)
        {
            this.seniority = seniority;
            this.salarysum = salarysum;
            CalculateSalary();
            Notify += Add;
        }
        public double _seniority { get { return seniority; } }
        public double _salarysum { get { return salarysum; } set { salarysum = value; } }

        public virtual void CalculateSalary()
        {
            salarysum = _salary + seniority * 0.2;
        }
        public virtual void Add()
        {
            Console.WriteLine("Успешно добавлен.");
        }
    }
}

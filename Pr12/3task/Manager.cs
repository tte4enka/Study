using System;
/*
 Класс менеджер (зав.отделом, управляющий) «Manager» - наследник
класса «Assistant», содержит все свойства родительского класса и
дополнительное свойство Количество подчиненных (Subordinate). Зарплата у
менеджера  рассчитывается как  оклад плюс стаж умноженный на 2%  плюс
количество подчиненных умноженное на 2% (Salarysum
=Salary+ Seniority*0.2+ Subordinate*0.2)
 */
namespace _3task
{
    public class Manager : Assistant
    {
        private long subordinate;

        public Manager()
        {
            subordinate = 0;
        }

        public Manager(string name, string fio, long salary, long seniority, long salarysum, long subordinate): base(name, fio, salary, seniority, salarysum)
        {
            this.subordinate = subordinate;
        }

        public long _subordinate { get { return subordinate; } set {  subordinate = value; } }

        public override double CalculateSalary()
        {
            _salarysum = base.CalculateSalary();
        }
    }
}

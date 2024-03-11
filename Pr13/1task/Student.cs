using System;

namespace _1task
{
    public class Student
    {
        private string _surname;
        private string _name;
        private delegate void EventHandler();
        private event EventHandler _onCall;

        public Student()
        {
            _onCall += CallMessage;
        }

        public Student(string surname, string name)
        {
            Surname = surname;
            Name = name;
            _onCall += CallMessage;
        }

        public string Surname { get => _surname; set => _surname = value; }
        public string Name { get => _name; set => _name = value; }

        public void OnCall()
        {
            _onCall();
        }

        public void CallMessage()
        {
            Console.WriteLine($"Учащийся {_surname} {_name} должен ответить");
        }
    }
}

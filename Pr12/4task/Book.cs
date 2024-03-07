using System;

namespace _4task
{
    public class Book
    {
        private string name;
        private string author;
        private string publisher;

        public Book()
        {
            name = "Unknown";
            author = "Unknown";
            publisher = "Unknown";
        }

        public Book(string name, string author, string publisher)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
        }

        public string _name { get { return name; } }
        public string _author { get { return author;} }
        public string _publisher { get {  return publisher;} }
    }
}

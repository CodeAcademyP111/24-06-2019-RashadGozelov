using System;

namespace ClassLesson
{
    class Person
    {
        public string Name;
        public string Surname;
        public DateTime Birthday;
        public Job work;

        public Person()
        {
            Console.WriteLine("Hello World");
        }

        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Person(string name, string surname,DateTime birthday):this(name,surname)
        {
            Birthday = birthday;
        }

        public string GetFullname()
        {
            return $"{Name} {Surname}";
        }

        public int GetAge()
        {
            return DateTime.Now.Year - Birthday.Year;
        }

        public virtual string FullInfo()
        {
            return $"{GetFullname()} ,Yashi: {GetAge()}";
        }
    }
}

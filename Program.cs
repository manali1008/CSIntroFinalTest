using System;

namespace CSIntroFinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[2];
            person[0] = new Adult("Sam", "Link");
            person[1] = new Child("Ria", "Singh");

            foreach(Person p in person)
            {
                p.PrintName();
            }
        }
    }

    class Person
    {
        protected string FirstName;
        protected string LastName;

        public Person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public virtual void PrintName() { }
    }
    
    class Adult : Person
    {
        public Adult(string fName, string lName) : base(fName,lName)
        { }

        public override void PrintName()
        {
            Console.WriteLine("Adult : {0} {1}", FirstName, LastName);
        }
    }

    class Child : Person
    {
        public Child(string fName, string lName) : base(fName, lName)
        { }

        public override void PrintName()
        {
            Console.WriteLine("Child : {0} {1}", FirstName, LastName);
        }
    }
}

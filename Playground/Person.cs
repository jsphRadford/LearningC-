using System;


namespace Playground
{
    public class Person
    {
        public string Name;

        public void introduce(string to)
        {
            Console.WriteLine("Hi {0},I am {1}", to, Name);

        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }


    }
}

//IN MAIN
//var person = Person.Parse("John");
//person.introduce("Mosh");
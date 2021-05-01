using System;

namespace LearningNullConditional
{
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = null;  
            Person person = new Person(); //{ Name = "Tim" }; 

            //Console.WriteLine(person?.Name?.Length);

            Console.WriteLine(person?.Name?? "Not Set");

            //if (person != null)
            //{
            //    Console.WriteLine(person.Name);
            //}
        }
    }
}

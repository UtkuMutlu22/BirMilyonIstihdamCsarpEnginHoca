using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Person[] person = new Person[3]
            {
                new Customer{ FirstName="utku"},new Student{ FirstName="arzu"},new Person{FirstName="Fuat"}
            };
        }
    }
    interface IPerson
    {

    }
    class Person:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person,IPerson
    {
        public string City { get; set; }
    }
    class Student:Person,IPerson
    {
        public int DemartmanId { get; set; }
    }
}

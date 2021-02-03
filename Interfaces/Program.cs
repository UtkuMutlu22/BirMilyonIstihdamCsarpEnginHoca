using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfacesIntro();

            // Interfaces1();
            ICustomerDal[] customerDals = new ICustomerDal[2] 
            { new SqlServerCustomerDal(), new OracleCustomerDal() };

            foreach (var customer in customerDals)
            {
                customer.Add();
            }
        }

        private static void Interfaces1()
        {
            IPerson person = new Customer();
            IPerson person2 = new Student();
            CustomerManager customer = new CustomerManager();
            customer.Add(new SqlServerCustomerDal());
        }

        private static void interfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "utku", LastName = "mutlu", Address = "Edirne" });
            Console.WriteLine();
            Student student = new Student { Id = 2, FirstName = "Arzu", LastName = "mutlu", Department = "computer science" };
            personManager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string  FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get;  set ; }
        public string FirstName { get; set; }
        public string LastName { get ; set ; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set ; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

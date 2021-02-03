using System;

namespace Contructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();
            Product product = new Product();
            product.Name = "Laptop";
            //ILogger databaseLogger = new DatabaseLogger();
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            //databaseLogger.Log();
            employeeManager.Add();
            PersonManager personManager = new PersonManager("product");

            Manager.DoSomething();
            Manager.DoSomething2();

            
        }
        class CustomerManager
        {
            private int _count=15;
            public CustomerManager(int count)
            {
                _count = count;
            }
            public CustomerManager()
            {

            }

            public void List()
            {
                Console.WriteLine("Listed {0}",_count);
            }
            public void Add()
            {

                Console.WriteLine("Added");
            }
        }
        class Product
        {
            public Product()
            {

            }
            private string _name;
            private int _id;
            public Product(int id,string name)
            {
                _id = id;
                _name = name;
            }

            public string Name { get; set; }
            public int Id { get; set; }
        }
        interface ILogger
        {
            void Log();
        }
        class DatabaseLogger:ILogger
        {
            public void Log()
            {
                Console.WriteLine("database to looger");
            }

           
        }
        class EmployeeManager
        {
           private ILogger _logger;
            public EmployeeManager(ILogger logger)
            {

                _logger = logger;
            }
            public void Add()
            {
                _logger.Log();
                Console.WriteLine("Added");
            }
        }
        class BaseClass
        {
            string _entity;
            public BaseClass(string entity)
            {
                _entity = entity;
            }
            public void Message()
            {
                Console.WriteLine("{0}",_entity);
            }
        }
        class PersonManager:BaseClass
        {
            public PersonManager(string entity):base(entity)
            {

            }
            public void Add()
            {
                Console.WriteLine("added to database");
                Message();
            }
        }
        static class Teacher
        {
            public static int Number { get; set; }
        }
        static class Utilitties
        {
            public static void Validate()
            {
                Console.WriteLine("Validation is done");

            }
            
        }
        class Manager
        {
            static Manager()
            {

            }
            public static void DoSomething()
            {
                Console.WriteLine("done");
            }
            public static void DoSomething2()
            {
                Console.WriteLine("done2");
            }
        }
    }
}

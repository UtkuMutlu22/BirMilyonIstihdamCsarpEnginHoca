using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

        
        }
    }
    class CustomerManager
    {
        public void Add()

        {
            Console.WriteLine("Customer Added");
        }
    }
    class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("database to loger");
        }
    }


    public interface ILogger
    {
        void Log();
    }
}

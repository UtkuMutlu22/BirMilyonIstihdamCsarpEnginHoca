using System;

namespace RecapDemo2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new FileBaseLogger());
            customerManager.Add();
            
            

        }
    }
    class CustomerManager
    {
        ILogger logger;
        public CustomerManager(ILogger loger)
        {
            logger = loger;
        }
        public void Add()
        {
            logger.Log();
            Console.WriteLine("Added");
        }
    }
    class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database Logged");
        }
    }
    class FileBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Logged");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Sms logger");
        }
    }
    interface ILogger
    {
        void Log();
    }
}

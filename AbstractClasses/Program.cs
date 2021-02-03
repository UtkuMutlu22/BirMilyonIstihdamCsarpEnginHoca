using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database databaseSql = new SqlServer();
            Database databaseOracle = new Oracle();

        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }
}

using System;

namespace VirtualMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SqlSever sqlSever = new SqlSever();
            MySql mySql = new MySql();
            sqlSever.Add();
            mySql.Add();
        }
    }

    internal class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Delete by default");
        }
    }

    internal class SqlSever : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SQL Code");
            base.Add();
        }
    }

    internal class MySql : Database
    {
    }
}
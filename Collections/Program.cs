using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = new string[2] { "Ankara", "İstanbul" };
            //cities[2] = "Adana";

            //ArrayList();

            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("Computer", "bilgisayar");
            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
           var result= dictionary.ContainsKey("glass");
            Console.WriteLine(result);
            var result2 = dictionary.ContainsKey("table");
            Console.WriteLine(result2);
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Edirne");
            cities.Add("İstanbul");
            cities.Add("Adana");
            Console.WriteLine(cities.Contains("Edirne"));
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { FirstName = "Utku", Id = 1 });
            customers.Add(new Customer { FirstName = "Arzu", Id = 2 });


            int result = customers.Count;
            var customer2 = new Customer
            { Id = 1, FirstName = "Mürvet " };
            customers.AddRange(new Customer[2]
            { new Customer {Id=4,FirstName="Fuat" },new Customer{Id=5,FirstName="Emre" } });

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.WriteLine("Count: {0}", result);

            Console.WriteLine(customers.Contains(customer2));
            var index = customers.IndexOf(customer2);
            Console.WriteLine(index);

            var lastIndexOf = customers.LastIndexOf(customer2);
            Console.WriteLine(lastIndexOf);

            customers.Insert(0, new Customer { FirstName = "Mustafa" });
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            customers.Remove(customer2);
            customers.RemoveAll((c => c.FirstName == "Utku"));
        }

        private static void ArrayList()
        {
            ArrayList cityList = new ArrayList();
            cityList.Add("Edirne");
            cityList.Add("Ankara");
            cityList.Add("Bursa");
            foreach (var city in cityList)
            {
                Console.WriteLine(city);
            }
            cityList.Add("Adana");
            Console.WriteLine(cityList[3]);
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName {get; set; }
    }
}

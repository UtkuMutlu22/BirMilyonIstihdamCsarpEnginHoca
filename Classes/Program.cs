using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Edirne";
            customer.FirstName = "Utku";
            customer.LastName = "Mutlu";
            Customer customer1 = new Customer()
            {
                Id = 1,
                FirstName = "Utku",
                LastName = "mutlu",
                City = "Edirne"
            };
            
        }
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }
        public void Update()
        {
            Console.WriteLine("Update");
        }
    }
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Added to product");
        }
        public void Update()
        {
            Console.WriteLine("Update to product");
        }
    }
}

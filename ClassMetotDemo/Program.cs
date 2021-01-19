using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Ali";
            customer1.CustomerLastName = "Alkan";
            customer1.CustomerAdress = "Iğdır";

            Customer customer2 = new Customer();
            customer2.CustomerName = "Ayşe";
            customer2.CustomerLastName = "Dal";
            customer2.CustomerAdress = "Hatay";

            Customer customer3 = new Customer();
            customer3.CustomerName = "Veli";
            customer3.CustomerLastName = "Çotuk";
            customer3.CustomerAdress = "Tekirdağ";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customer1);

            Console.WriteLine("------------------------------------------");
            customerManager.List(customers);

            Console.WriteLine("--------------------------");

            customerManager.CustomerUpdate(customer2);
            Console.WriteLine("--------------------------");

            customerManager.CustomerDelete(customer3);

            Console.WriteLine("--------------------------");




        }
    }
}

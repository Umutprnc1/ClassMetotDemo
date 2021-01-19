using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
       public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Müşteri Ekle:{customer.CustomerName} {customer.CustomerLastName}{customer.CustomerAdress}" +" ===="+"Başarılı. Müşteri Eklendi");
        }
        public void CustomerUpdate(Customer customer)
        {
            Console.WriteLine("Müşteri Güncelle:{customer.CustomerName} {customer.CustomerLastName}{customer.CustomerAdress}" + " ====" + "Başarılı. Müşteri Güncellendi");
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi:{customer.CustomerName} {customer.CustomerLastName}{customer.CustomerAdress}" + " ====" + "Başarılı. Müşteri Silindi");
        }

        public void List(Customer[]customers)
        {
            foreach (var list in customers)
            {
                Console.WriteLine("Müşteri Adı :"+list.CustomerName);
                Console.WriteLine(" ");
                Console.WriteLine("Müşteri soyadı :" + list.CustomerLastName);
                Console.WriteLine(" ");
                Console.WriteLine("Müşteri Adresi :" + list.CustomerAdress);
                Console.WriteLine(" ");
                Console.WriteLine("**************************************************");

            }
        }

    }
}

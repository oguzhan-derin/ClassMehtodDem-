using System;
using System.Collections.Generic;
using System.Text;

namespace classMetotDem
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Tebrikler! \n" +customer.Name +" "+customer.LastName+" bankamızda yeni hesabınız açılmıştır!");
        }
        public void Delete(Customer customer)
        {

            Console.WriteLine("Üzüldük." + customer.Name + " " + customer.LastName + " Bankamızdaki hesabınız kapatılmıştır.");
        }
       
    }
}

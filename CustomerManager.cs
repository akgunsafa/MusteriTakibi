using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void add(Customers customer) {
            Console.WriteLine(customer.Name+" "+customer.LastName+" "+"eklendi"); 
        }
        public void delete(Customers customer) {
            Console.WriteLine(customer.Name + " " + customer.LastName + " " + "silindi"); 
        }
        public void get(Customers customer) {
            Console.WriteLine(customer.AccountNumber+" "+ customer.Name+" "+customer.LastName
                +" "+customer.TelephoneNumber+" "+customer.MailAdress); 
        }
        
    }
}

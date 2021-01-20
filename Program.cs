using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new Customers();
            customer1.AccountNumber = 123456789;
            customer1.Name = "safa";
            customer1.LastName = "akgün";
            customer1.TelephoneNumber =05428888888;
            customer1.MailAdress = "asndlam@gmail.com";

            Customers customer2 = new Customers();
            customer2.AccountNumber = 987654321;
            customer2.Name = "büşranur";
            customer2.LastName = "özekli";
            customer2.TelephoneNumber =05435555555;
            customer2.MailAdress = "svahdsj@gmail.com";

            CustomerManager customerManager = new CustomerManager();
            customerManager.add(customer1);
            customerManager.add(customer2);
            customerManager.delete(customer1);
            customerManager.delete(customer2);
            customerManager.get(customer1);
            customerManager.get(customer2);





        }
    }
}

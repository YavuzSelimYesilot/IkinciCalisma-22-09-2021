using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();                      //*Önemli

            customer1.Id = 1;
            customer1.CustomerNo = "2255";
            customer1.Name = "Ömer";
            customer1.Surname = "Halis";
            customer1.TcNo = "150716";


            CooperateCustomer customer2 = new CooperateCustomer();                       //*Önemli

            customer2.Id = 2;
            customer2.CustomerNo = "5588";
            customer2.CompanyName = "SpaceX";
            customer2.TaxNo = "14753";

            // * S O L I D *

            Customer customer3 = new IndividualCustomer();                              //**Önemli
            Customer customer4 = new CooperateCustomer();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}

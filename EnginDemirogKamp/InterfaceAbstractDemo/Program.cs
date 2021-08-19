using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerCheckService customerService = new CustomerCheckManager();
            BaseCustomerManager customerManager = new StarbucksCustomerManager(customerService);
            Customer customer1 = new Customer { DateofBirth = new DateTime(1985, 1, 6), FirstName = "Ege", LastName = "Kol", Id = 1, NationalityId = "11111" };
            //CustomerCheckManager checkManager = new CustomerCheckManager();

            
            customerManager.Save(customer1);
           




        }
    }
}

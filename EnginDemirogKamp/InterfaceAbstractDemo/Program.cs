using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICustomerCheckService customerService = new MernisServiceAdapter();
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            Customer customer1 = new Customer { DateofBirth = new DateTime(2000, 1, 1), FirstName = "Ege", LastName = "Kol", Id = 1, NationalityId = "19669944334" };
            //CustomerCheckManager checkManager = new CustomerCheckManager();

            
            customerManager.Save(customer1);
           




        }
    }
}

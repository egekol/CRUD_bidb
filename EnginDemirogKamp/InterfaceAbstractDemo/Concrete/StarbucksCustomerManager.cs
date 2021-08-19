using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealCustomer(customer))
            {
                base.Save(customer);
                Console.WriteLine("Your Starbucks Token has been added.");
                //Abstract
            }
            else
            {
                Console.WriteLine("Not A Valid Person");
                //throw new Exception("Not a valid Person");
            }
            
        }

    }
}

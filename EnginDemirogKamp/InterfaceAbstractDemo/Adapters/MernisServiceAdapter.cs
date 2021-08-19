using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateofBirth.Year);
            //   KPSPublicSoapClient client = new KPSPublicSoapClient;
            //return 
        }
    }
}

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

    //ADAPTER-DESIGN PATTERN
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateofBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
            //   KPSPublicSoapClient client = new KPSPublicSoapClient;
            //return 
        }
    }
}

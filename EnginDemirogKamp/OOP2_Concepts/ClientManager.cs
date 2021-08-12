using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Concepts
{
    class ClientManager
    {
        public void Add(Client client)
        {
            Console.WriteLine("Customer has been added.\n" + 
                              "The client id is " + client.Id);

            if (client.Id == 1)
            {
                Console.WriteLine("Customer name is: ");
            }
        }

    }
}

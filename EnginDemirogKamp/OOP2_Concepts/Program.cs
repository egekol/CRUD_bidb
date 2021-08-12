using System;

namespace OOP2_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Client client0 = new Client();
            client0.Id = 1;
            client0.ClientNumber = "1101";

            Coorporate coorporate = new Coorporate();
            coorporate.CompName = "Alibeyler";
            coorporate.TaxNumber = "322232";
            coorporate.Id = 2;
            

            ClientManager clientManager = new ClientManager();
            clientManager.Add(client0);
            clientManager.Add(coorporate);

            Console.WriteLine("-------------------------------");

            //kurs
            //Engin Demirog
            IndividualClient client1 = new IndividualClient();
            client1.Id = 1;
            client1.ClientNumber = "11111";
            client1.Name = "Engin";
            client1.Surname = "Demiroğ";
            client1.TcId = "19111111111";

            //kodlama.io
            Coorporate client2 = new Coorporate();
            client2.Id = 2;
            client2.ClientNumber = "12345";
            client2.CompName = "kodlama.io";
            client2.TaxNumber = "111112";

            //------------------------------------------------------

            Client client3 = new Coorporate();
            Client client4 = new IndividualClient();

            clientManager.Add(client1);
            clientManager.Add(client2);
            clientManager.Add(client3);
            clientManager.Add(client4);






        }
    }
}

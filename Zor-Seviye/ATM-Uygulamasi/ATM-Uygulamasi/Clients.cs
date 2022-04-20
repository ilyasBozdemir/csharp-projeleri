using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ATM_Uygulamasi
{
    public class Clients
    {
        public List<Client> clientList { get; set; }
        public Clients()
        {
            clientList = new List<Client>();
            clientList.Add(new Client()
            {
                Id = 12345,
                Name = "ilyas",
                Surname = "Bozdemir",
                Balance = 100000,
                Password = "1234",
                Username = "ibozdemir96"
            });
            clientList.Add(new Client()
            {
                Id = 54321,
                Name = "Mehmet",
                Surname = "Gültekin",
                Balance = 50000,
                Password = "4321",
                Username = "ibozdemir96"
            });
        }
    }
}

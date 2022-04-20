using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    public class Client
    {
        public int id;
        public string name, password;
        public double balance = 0;
        public Client(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public Client(string name, string password, double balance)
        {
            this.name = name;
            this.password = password;
            this.balance = balance;
        }
    }
}

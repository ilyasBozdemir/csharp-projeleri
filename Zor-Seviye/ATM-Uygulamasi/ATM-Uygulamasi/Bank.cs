using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    public class Bank 
    {
        private  Customer _customer;
        public bool InSignIn;
        public bool LogIn(Customer customer)
        {
            _customer = customer;
            //dogrulama kısmı yazılcak.
            InSignIn = true;

            return InSignIn;
        }
        public bool CheckOut(Customer customer)
        {
            return InSignIn = false;
        }
        public void TakeTheEndOfTheDay()//günsonu al
        {

        }

    }
}

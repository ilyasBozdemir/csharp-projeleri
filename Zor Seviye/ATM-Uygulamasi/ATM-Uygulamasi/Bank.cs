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
        private bool InSignIn;
        public void LogIn(Customer customer)
        {
            _customer = customer;
        }
        public void CheckOut(Customer customer)
        {
            
        }
        public bool IsTheCustomerSignedIn()
        {
            
            return false;
        }
    }
}

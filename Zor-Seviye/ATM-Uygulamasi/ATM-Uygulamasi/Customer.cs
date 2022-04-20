using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    public class Customer 
    {
        public int customerID { get ; set; }
        public string customerName { get; set; }
        public string customerSurname { get; set; }
        public string customerPassword { get; set; }
        public CustomerBalance customerBalance { get; set; }
    }
    public class customerTransactions 
    {
        private Customer _customer;
        public void BalanceInquiry()//bakiye sorgulama
        {
            
        }

        public void ToDepositMoney(double balance)//para yatır.
        {
            
        }

        public void ToPay(Customer customer, double Balance)//ödeme yap.
        {
           
        }
        public void SendMoney(Customer customer, double Balance)
        {

        }

        public void WithdrawMoney(double balance)//para çek
        {
            
        }

    }
    public class CustomerBalance
    {
        public int customerID { get; set; }
        public double customerBalance { get; set; }
    }
}

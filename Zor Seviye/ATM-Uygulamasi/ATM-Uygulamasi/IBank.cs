using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    public interface IBank
    {
        void LogIn(ICustomer customer );
        void CheckOut(ICustomer customer);
    }
}

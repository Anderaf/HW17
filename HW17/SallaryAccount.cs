using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    public class SallaryAccount : IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public SallaryAccount(double balance) 
        { 
            Balance = balance;
        }

        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}

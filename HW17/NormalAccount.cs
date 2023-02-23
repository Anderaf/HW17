using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    public class NormalAccount : IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public NormalAccount(double balance) 
        {
            Balance = balance;
        }

        public void CalculateInterest()
        {
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }
}

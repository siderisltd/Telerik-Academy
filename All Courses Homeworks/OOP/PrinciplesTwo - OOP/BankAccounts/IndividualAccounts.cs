using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class IndividualAccounts : Account
    {
        public IndividualAccounts()
        {
        }
        public IndividualAccounts(decimal balance, decimal monthlyRate, AccountType typeOfAccount)
            : base(balance, monthlyRate, typeOfAccount)
        {
        }
    }
}

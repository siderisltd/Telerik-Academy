using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public interface IInterest
    {
        decimal InterestAmountForPeriod(decimal monthlyInterestRate);
    }
}

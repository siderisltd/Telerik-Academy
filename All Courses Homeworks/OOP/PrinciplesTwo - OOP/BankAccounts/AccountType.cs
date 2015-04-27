using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
   public enum AccountType
    { 
        Unknown, 
        Deposit,
        Loan, 
        Mortgage 
    };
   public class AccountTypes
   {
       public AccountType Type { get; set; }
   }
}

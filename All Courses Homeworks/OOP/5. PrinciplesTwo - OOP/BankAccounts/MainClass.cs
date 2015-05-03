using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class MainClass
    {
        static void Main()
        {
            IndividualAccounts IndividualDeposit = new IndividualAccounts(134.3m, 12.5m, AccountType.Deposit);
            IndividualAccounts IndividualLoan = new IndividualAccounts(200.3m, 11.5m, AccountType.Loan);
            IndividualAccounts IndividualMortgage = new IndividualAccounts(15.000m, 7.9m, AccountType.Mortgage);

            CompanyAccounts CompanyDeposit = new CompanyAccounts() { AccountType = AccountType.Deposit, Balance = 1234.23m, MonthlyInterestRate = 21.2m };

            CompanyAccounts CompanyLoan = new CompanyAccounts()
            {
                AccountType = AccountType.Loan,
                Balance = 5434.34m,
                MonthlyInterestRate = 8.9m
            };

            CompanyAccounts CompanyMortgage = new CompanyAccounts();
            CompanyMortgage.AccountType = AccountType.Loan;
            CompanyMortgage.Balance = 5434.34m;
            CompanyMortgage.MonthlyInterestRate = 8.9m;

            IList<Account> accounts = new List<Account>();
            accounts.Add(IndividualDeposit);
            accounts.Add(IndividualLoan);
            accounts.Add(IndividualMortgage);
            accounts.Add(CompanyDeposit);
            accounts.Add(CompanyLoan);
            accounts.Add(CompanyMortgage);

            foreach (var acc in accounts)
            {
                Console.WriteLine(acc.InterestAmountForPeriod(7.9m));
            }

        }
    }
}

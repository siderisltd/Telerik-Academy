using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Account : IInterest
    {
        private bool CanWithDraw = false;

        private bool CanDeposit = true;

        public decimal Balance { get; set; }

        public decimal MonthlyInterestRate { get; set; }

        private AccountTypes accountType;

        public Account()
        {
            accountType = new AccountTypes();
        }
        public Account(decimal balance, decimal monthlyInterestRate, AccountType typeOfAccount)
        {
            accountType = new AccountTypes();
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
            this.AccountType = typeOfAccount;
        }

        public AccountType AccountType
        {
            get
            {
                return this.accountType.Type;
            }
            set
            {
                this.accountType.Type = value;
            }
        }
//    Deposit accounts are allowed to deposit and with draw money.
//    Loan and mortgage accounts can only deposit money.

        public virtual decimal InterestAmountForPeriod(decimal monthlyInterestRate)
        {
            decimal period;
            Console.Write("Type period in months : ");
            period = decimal.Parse(Console.ReadLine());
            decimal interest = period * monthlyInterestRate;
            interest = CheckAccountType(interest , monthlyInterestRate);
            return interest;
        }


        public void Deposit(decimal ammount)
        {
            CheckAccountPremissions();
            if (CanDeposit)
            {
                this.Balance += ammount;
            }
            else
            {
                Console.WriteLine("The account type is not set !");
            }
        }

        public void WithDraw(decimal ammount)
        {
            CheckAccountPremissions();
            if (CanWithDraw)
            {
                this.Balance -= ammount;
            }
            else
            {
                Console.WriteLine("Only Deposit Accounts can withdraw");
            }
        }

        private void CheckAccountPremissions()
        {
            switch (this.accountType.Type)
            {
                case AccountType.Deposit:
                    CanWithDraw = true;
                    CanDeposit = true;
                    break;
                case AccountType.Loan:
                    CanWithDraw = false;
                    CanDeposit = true;
                    break;
                case AccountType.Mortgage:
                    CanWithDraw = false;
                    CanDeposit = true;
                    break;
                default:
                    Console.WriteLine("Account type is not set");
                    CanWithDraw = false;
                    CanDeposit = false;
                    break;
            }
        }

        private decimal CheckAccountType(decimal interest, decimal monthlyRate)
        {
            switch (this.GetType().Name)
            {
                case "IndividualAccounts":
                    if (accountType.Type == AccountType.Loan)
                    {
                        Console.WriteLine("Individual Loan Accounts Have 3 Months Free Interest Rate");
                        interest -= 3 * monthlyRate;
                        if (interest <= 0)
                        {
                            interest = 0;
                        }
                    }
                    if (accountType.Type == AccountType.Deposit)
                    {
                        if (this.Balance <= 1000)
                        {
                            Console.WriteLine("Balance is below 1000 USD and there are no interest rate");
                            interest = 0;
                        }
                    }
                    if (accountType.Type == AccountType.Mortgage)
                    {
                        Console.WriteLine("Individual Mortgage Accounts Have 6 Months Free Interest Rate");
                        interest -= 6 * monthlyRate;
                        if (interest <= 0)
                        {
                            interest = 0;
                        }
                    }
                    break;
                case "CompanyAccounts":
                    if (accountType.Type == AccountType.Loan)
                    {
                        Console.WriteLine("Company Loan Accounts Have 2 Months Free Interest Rate");
                        interest -= 2 * monthlyRate;
                        if (interest <= 0)
                        {
                            interest = 0;
                        }
                    }
                    if (accountType.Type == AccountType.Deposit)
                    {
                        if (this.Balance <= 1000)
                        {
                            Console.WriteLine("Balance is below 1000 USD and there are no interest rate");
                            interest = 0;
                        }
                    }
                    if (accountType.Type == AccountType.Mortgage)
                    {
                        Console.WriteLine("Company Mortgage Accounts Have 1/2 interest rate in the first 12 months");
                        interest = interest - ((12 * monthlyRate)/2);
                        if (interest <= 0)
                        {
                            interest = 0;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Account type is not Completely set !");
                    break;
            }
            return interest;
        }
    }
}

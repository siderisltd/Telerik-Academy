using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyConsoleClient.Interfaces
{
    public interface IPurchasable
    {
        decimal BuyingPrice { get; }
        decimal SellingPrice { get; }
        decimal MortgageValue { get; }
        decimal Rent { get; }
        bool Mortgaged { get; set; }
        bool Owned { get; set; }
    }
}

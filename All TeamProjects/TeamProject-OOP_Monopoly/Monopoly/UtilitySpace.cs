namespace Monopoly
{
    using MonopolyConsoleClient.Interfaces;

    public class UtilitySpace : PurchasableSpace, IPurchasable
    {
        public UtilitySpace(string currentName, decimal currentPrice, decimal currentMortgageValue, decimal currentRent) :         
            base(currentName, currentPrice, currentMortgageValue, currentRent)
        {           
        }  
    }
}

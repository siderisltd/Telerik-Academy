namespace Monopoly
{
    using MonopolyConsoleClient.Interfaces;

    public class RailRoad : PurchasableSpace, IPurchasable
    {
        public RailRoad(string currentName, decimal currentPrice, decimal currentMortgageValue, decimal currentRent) 
            : base(currentName, currentPrice, currentMortgageValue, currentRent)
        {           
        }
    }
}

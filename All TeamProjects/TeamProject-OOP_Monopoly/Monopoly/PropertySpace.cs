namespace Monopoly
{
    using System;
    using MonopolyConsoleClient.Interfaces;

    public class PropertySpace : PurchasableSpace, IPurchasable, IStreet
    {
        public PropertySpace(string currentName, decimal currentPrice, decimal currentMortgageValue, decimal currentRent,
            int rentWithOneHouse, int rentWithTwoHouses, int rentWithThreeHouses, int rentWithFourHouses, int rentWithHotel, Color color)
            : base(currentName, currentPrice, currentMortgageValue, currentRent)
        {
            this.NumberOfhouses = 0;
            this.Hotel = 0;
            this.RentWithOneHouse = rentWithOneHouse;
            this.RentWithTwoHouses = rentWithTwoHouses;
            this.RentWithThreeHouses = rentWithThreeHouses;
            this.RentWithFourHouses = rentWithFourHouses;
            this.RentWithHotel = rentWithHotel;
            this.Color = color;
        }

        public int NumberOfhouses { get; set; }
        public int Hotel { get; set; }
        public int RentWithOneHouse { get; private set; }
        public int RentWithTwoHouses { get; private set; }
        public int RentWithThreeHouses { get; private set; }
        public int RentWithFourHouses { get; private set; }
        public int RentWithHotel { get; private set; }
        public Color Color { get; private set; }
    }
}

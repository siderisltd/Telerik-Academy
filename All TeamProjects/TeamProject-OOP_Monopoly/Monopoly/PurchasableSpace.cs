namespace Monopoly
{
    using MonopolyConsoleClient.Interfaces;
    using System;

    public abstract class PurchasableSpace : Space
    {
        private const decimal MinPropertyPrice = 1;
        private const decimal MinMortgageValue = 1;
        private const decimal MinRentPrice = 1;

        private decimal buyingPrice;
        private decimal sellingPrice;
        private decimal mortgageValue;
        private decimal rent;
        private bool mortgaged;
        private bool owned;

        //the idea is - all prices to be created when the object is created, as everything like price, name and etc is given in the beginning of the game.
        public PurchasableSpace(string currentName, decimal currentPrice, decimal currentMortgageValue, decimal currentRent)
            : base(currentName)
        {
            this.BuyingPrice = currentPrice;
            this.SellingPrice = this.BuyingPrice / 2;
            this.MortgageValue = currentMortgageValue;
            this.Rent = currentRent;
            this.Mortgaged = false;
            this.Owned = false;
        }

        //the set of Name and prices will be private because the values cannot change in the game. 
        //TODO: Move implementation of the Name property to super class Space

        public decimal BuyingPrice
        {
            get
            {
                return this.buyingPrice;
            }
            private set
            {
                if (value < MinPropertyPrice)
                {
                    throw new ArgumentOutOfRangeException("The property buying prices cannot be lower than {0}", MinPropertyPrice.ToString());
                }

                this.buyingPrice = value;
            }
        }

        public decimal Rent
        {
            get
            {
                return this.rent;
            }
            private set
            {
                if (value < MinRentPrice)
                {
                    throw new ArgumentOutOfRangeException("The Rent cannot be lower than {0}", MinRentPrice.ToString());
                }

                this.rent = value;
            }
        }

        public decimal SellingPrice
        {
            get
            {
                return this.sellingPrice;
            }
            private set
            {
                //no check here, because the selling prices is calculated, besed on buying price, if buying prices is ok, no need to check here.
                this.sellingPrice = value;
            }
        }

        public decimal MortgageValue
        {
            get
            {
                return this.mortgageValue;
            }
            private set
            {
                if (value < MinMortgageValue)
                {
                    throw new ArgumentOutOfRangeException("Mortgage value cannot be 0 or negative");
                }

                this.mortgageValue = value;
            }
        }
        public bool Mortgaged
        {
            get
            {
                return this.mortgaged;
            }
            set
            {
                this.mortgaged = value;
            }
        }

        public bool Owned
        {
            get
            {
                return this.owned;
            }
            set
            {
                this.owned = value;
            }
        }

    }
}

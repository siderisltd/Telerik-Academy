namespace Monopoly
{
    using System;

    public class Building
    {
        private const decimal MinPrice = 1;

        private BuildingType type;
        private decimal buyPrice;
        private decimal sellPrice;

        public Building(BuildingType currentType, decimal currentBuyPrice, decimal currentSellPrice)
        {
            this.type = currentType;
            this.BuyingPrice = currentBuyPrice;
            this.SellingPrice = currentSellPrice;
        }


        public BuildingType Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                this.type = value;
            }
        }
        public decimal BuyingPrice
        {
            get
            {
                return this.buyPrice;
            }
            set
            {
                if (value < MinPrice)
                {
                    throw new ArgumentOutOfRangeException("BuyingPrice cannot be lower than {0}", MinPrice.ToString());
                }

                this.buyPrice = value;
            }
        }

        public decimal SellingPrice
        {
            get
            {
                return this.sellPrice;
            }
            set
            {
                if (value < MinPrice)
                {
                    throw new ArgumentOutOfRangeException("SellingPrice cannot be lower than {0}", MinPrice.ToString());
                }

                this.sellPrice = value;
            }
        }       
    }
}

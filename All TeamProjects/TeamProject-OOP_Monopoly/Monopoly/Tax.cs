namespace Monopoly
{
    using Monopoly;

    public class Tax: NotPurchasableSpace
    {
        public Tax(int taxToPay)
            :base("Tax")
        {
            this.TaxToPay = taxToPay;
        }

        public int TaxToPay { get; set; }
    }
}

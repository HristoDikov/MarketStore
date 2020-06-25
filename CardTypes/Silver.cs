namespace MarketStore.CardTypes
{
    using MarketStore.GlobalConstants;
    public class Silver : Card
    {
        public Silver(decimal turnOver, decimal purchaseValue)
            : base(turnOver, purchaseValue)
        {
            this.DiscountRate = SetDiscountRate(turnOver, purchaseValue);
            this.Discount = this.Discount;
            this.Total = this.TotalPurchase();

        }

        protected override decimal SetDiscountRate(decimal turnOver, decimal purchaseValue)
        {
            if (turnOver >= GlobalConstants.ThreeHundredDollarsTurnOver) // = 300
            {
                return GlobalConstants.SilverMaxDiscountRate; // = 3.5
            }

            return GlobalConstants.SilverInitialDiscountRate; // = 2
        }
    }
}

namespace MarketStore.CardTypes
{
    using MarketStore.GlobalConstants;

    public class Bronze : Card
    {
        public Bronze(decimal turnOver, decimal purchaseValue)
            : base(turnOver, purchaseValue)
        {
            this.DiscountRate = SetDiscountRate(turnOver, purchaseValue);
            this.Discount = this.Discount;
            this.Total = this.TotalPurchase();
        }

        protected override decimal SetDiscountRate(decimal turnOver, decimal purchaseValue)
        {
            if (turnOver < GlobalConstants.HundredDollarsTurnOver) // = 100
            {
                return GlobalConstants.BronzeNoDiscountRate; // = 0
            }
            else if (turnOver <= GlobalConstants.HundredDollarsTurnOver && turnOver <= GlobalConstants.ThreeHundredDollarsTurnOver)
            {
                return GlobalConstants.BronzeLowestDiscountRate; // = 1
            }
            else
            {
                return GlobalConstants.BronzeHighestDiscountRate; // = 2.5
            }
        }


    }
}

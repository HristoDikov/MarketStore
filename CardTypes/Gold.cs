namespace MarketStore.CardTypes
{
    using MarketStore.GlobalConstants;

    public class Gold : Card
    {
        public Gold(decimal turnOver, decimal purchaseValue)
            : base(turnOver, purchaseValue)
        {
            this.DiscountRate = SetDiscountRate(turnOver, purchaseValue);
            this.Discount = this.Discount;
            this.Total = this.TotalPurchase();
        }


        protected override decimal SetDiscountRate(decimal turnOver, decimal purchaseValue)
        {
            decimal initialDiscountRate = GlobalConstants.GoldInitialDiscountRate; // = 2

            while (turnOver >= GlobalConstants.HundredDollarsTurnOver) // = 100
            {
                initialDiscountRate += GlobalConstants.GoldCardDiscountGrowth; // = 1
                turnOver -= GlobalConstants.HundredDollarsTurnOver; // = 100

                if (initialDiscountRate == GlobalConstants.GoldMaxDiscountRate) // = 10
                {
                    return GlobalConstants.GoldMaxDiscountRate; // = 10
                }
            }

            return initialDiscountRate;
        }

    }
}

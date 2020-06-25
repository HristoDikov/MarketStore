namespace MarketStore.GlobalConstants
{
    public class GlobalConstants
    {
        public const decimal BronzeNoDiscountRate = 0;
        public const decimal BronzeLowestDiscountRate = 1;
        public const decimal BronzeHighestDiscountRate = 2.5m;

        public const decimal SilverInitialDiscountRate = 2;
        public const decimal SilverMaxDiscountRate = 3.5m;

        public const decimal GoldInitialDiscountRate = 2;
        public const decimal GoldMaxDiscountRate = 10;
        public const decimal GoldCardDiscountGrowth = 1;
        public const decimal GoldMinTurn = 1;

        public const int HundredDollarsTurnOver = 100;
        public const int ThreeHundredDollarsTurnOver = 300;
    }
}

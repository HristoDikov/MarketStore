namespace MarketStore.Contracts
{
    public interface ICard
    {
        public decimal TurnOver { get; set; }

        public decimal DiscountRate { get; set; }

        public decimal PurchaseValue { get; set; }

        public decimal Discount { get; set; }

        public decimal Total { get; set; }

        public decimal TotalPurchase();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore.CardTypes
{
    public abstract class Card
    {
        private decimal discount;

        protected Card(decimal turnOver, decimal purchaseValue)
        {
            this.TurnOver = turnOver;
            this.PurchaseValue = purchaseValue;
        }

        protected decimal TurnOver { get; set; }

        protected decimal DiscountRate { get; set; }

        protected decimal PurchaseValue { get; set; }

        protected decimal Discount
        {
            get { return this.discount; }
            set { this.discount = this.PurchaseValue * this.DiscountRate / 100; }
        }

        protected decimal Total { get; set; }

        protected abstract decimal SetDiscountRate(decimal turnOver, decimal purchaseValue);

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Purchase value: ${PurchaseValue:F2}")
                .AppendLine($"Discount rate: {DiscountRate}%")
                .AppendLine($"Discount: ${this.Discount:F2}")
                .Append($"Total: ${this.Total:F2}");

            return sb.ToString();
        }

        protected decimal TotalPurchase()
        {
            return this.Total = this.PurchaseValue - this.Discount;
        }

    }
}

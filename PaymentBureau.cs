using MarketStore.CardTypes;
using System;
using System.Collections.Generic;

namespace MarketStore
{
    public class PaymentBureau
    {
        public Card Card { get; set; }

        public void SetCard(string cardType, decimal turnOver, decimal purchaseValue)
        {
            this.Card = cardType switch
            {
                "Bronze" => new Bronze(turnOver, purchaseValue),
                "Silver" => new Silver(turnOver, purchaseValue),
                "Gold" => new Gold(turnOver, purchaseValue),
                _ => throw new NotImplementedException(),
            };

        }

        public string PaymentInfo()
        {
            return Card.ToString();
        }
    }
}

namespace Monopoly
{
    using System.Collections.Generic;

    using Monopoly;
    using Monopoly.Cards;
    using Monopoly.Interfaces;

    public class CommunityChestSpace : NotPurchasableSpace, IDrawCard
    {
        private Queue<ChanceCard> communityCards;
        
        public CommunityChestSpace()
            :base("Community Chest")
        {
            this.communityCards = CardInitializer.InitializeChanceList();
        }

        public ChanceCard DrawCard()
        {
            ChanceCard topCard = communityCards.Dequeue();
            return topCard;
        }
    }
}

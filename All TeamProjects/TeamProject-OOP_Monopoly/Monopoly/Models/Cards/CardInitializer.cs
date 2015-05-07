namespace Monopoly.Cards
{
    using System;
    using System.Collections.Generic;

    public class CardInitializer
    {

        private static List<ChanceCard> community = new List<ChanceCard>()
        {
            //new SpaceCard("Advance to Go (Collect $200)", new Space(), CardType.LuckyCard), // Please enter the start field here when created.
            new GoodLuckCard("Bank Error In Your Favor – Collect $200", CardType.LuckyCard, 200),
            new GoodLuckCard("Doctor's Fee – Pay $50 ", CardType.BadLuckCard, 50),
            new SpaceCard("Get Out of Jail Free – This card may be kept until needed, or sold", 3, CardType.LuckyCard), // please add Jail Space - if Jail space and lucky card - then you can save.
            //new SpaceCard("Go to Jail – Go Directly to Jail", new Space(), CardType.LuckyCard),
            //new GoodLuckCard("Grand Opera Opening – Collect $50", CardType.LuckyCard, 50),
            //new GoodLuckCard("Income Tax refund – Collect $20 ", CardType.LuckyCard, 20),
            //new GoodLuckCard("Life Insurance Matures – Collect $100 ", CardType.LuckyCard, 100),
            //new GoodLuckCard("Pay Hospital $100 ", CardType.BadLuckCard, 100),
            //new GoodLuckCard("Pay School Tax of $150 ", CardType.BadLuckCard, 150),
            //new GoodLuckCard("Receive For Services $25 ", CardType.LuckyCard, 25),
            //new GoodLuckCard("You Have Won Second Prize in a Beauty Contest – Collect $10", CardType.LuckyCard, 10),
            //new GoodLuckCard("You Inherit $100", CardType.LuckyCard, 100),
            //new GoodLuckCard("From Sale of Stock You Get $45", CardType.LuckyCard, 45),
            //new GoodLuckCard("Xmas Fund Matures - Collect $100", CardType.LuckyCard, 100)
        };

        private static List<ChanceCard> chanceList = new List<ChanceCard>()
        {
            //new SpaceCard("Advance to Go (Collect $200)",4, CardType.LuckyCard), // space to be replaced with Start.
            new GoodLuckCard("Your Building And Loan Matures – Collect $150", CardType.LuckyCard, 150),
            new SpaceCard("Advance to Illinois Ave.", 7, CardType.Neutral), // space to be replaced with Illinois Ave
            //new SpaceCard("Advance token to nearest Utility. If unowned, you may buy it from the Bank", , CardType.Neutral),// repalce with nearest utility.
            //new SpaceCard("Advance token to the nearest Railroad and pay owner twice the rental to which he/she is otherwise entitled.", new Space(), CardType.BadLuckCard),
            //new SpaceCard("Advance to St. Charles Place", 6, CardType.Neutral),
            //new GoodLuckCard("Get out of Jail free", CardType.LuckyCard),
            //new MoveCard("Go back 3 spaces", CardType.Neutral, 3),
            //new SpaceCard("Go directly to Jail", new Space(), CardType.BadLuckCard),
            //new SpaceCard("Take a trip to Reading Railroad – if you pass Go collect $200", new Space(), CardType.LuckyCard),
            //new SpaceCard("Take a Walk on the Board Walk", new Space(), CardType.Neutral),
            
       };

        public static Queue<ChanceCard> InitializeCommunityList()
        {
            community.Shuffle<ChanceCard>();
            return new Queue<ChanceCard>(community);
        }

        public static Queue<ChanceCard> InitializeChanceList()
        {
            chanceList.Shuffle<ChanceCard>();
            return new Queue<ChanceCard>(chanceList);
        }

    }
}

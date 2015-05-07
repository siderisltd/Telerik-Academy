namespace Monopoly.Players
{
    using System;
    using System.Collections.Generic;

    using Monopoly.Cards;
    using Monopoly.Interfaces;
    using MonopolyConsoleClient.Models.Players;

    public class Player : Element
    {
        //this is forchecking the turns 
        bool IsGameOver;
        public int PlayerNumber { get; set; }
        //
        private int bankroll;
        public string Name { get; set; }
        //private List<purchasableSpaces> ownedSpaces = new List<purchasableSpaces>();
        private int totalValue;
        private int position;
        private List<PurchasableSpace> listOfProperties;
        public int OwnedStations { get; set; }
        public int OwnedUtilities { get; set; }
        public Symbols Symbol { get; private set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public bool IsInJail  { get; set; }

        public Player(int playerNumber, string playerName, Symbols symbol, int startPos = 0, int startBankroll = 500, int ownedStations = 0, int ownedUtilities = 0)
        {
            this.PlayerNumber = playerNumber;
            this.Name = playerName;
            this.Position = startPos;
            this.Bankroll = startBankroll;
            this.OwnedStations = ownedStations;
            this.OwnedUtilities = ownedStations;
            this.listOfProperties = new List<PurchasableSpace>();
            this.Symbol = symbol;
            this.PosX = 110 + this.PlayerNumber;
            this.PosY = 72;
        }

        public int Bankroll
        {
            get
            {
                return this.bankroll;
            }
            set
            {
                this.bankroll = value;
            }
        }
        public int Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }

        public int TotalValue
        {
            get
            {
                return this.totalValue;
            }
            set
            {
            }
        }

        public List<PurchasableSpace> ListOfProperties
        {
            get
            {
                return new List<PurchasableSpace>(this.listOfProperties);
            }
        }

        public void AddCash(int moneyToAdd)
        {
            this.Bankroll = this.Bankroll + moneyToAdd;
        }

        public void AddSpace(PurchasableSpace  boughtProperty)
        {
            listOfProperties.Add(boughtProperty);
        }

        public void RemoveCash(int moneyToRemove)
        {
            this.Bankroll = this.Bankroll - moneyToRemove;
        }

        public override string ToString()
        {
            return this.Symbol.ToString();
        }

        public ChanceCard DrawCard(Queue<ChanceCard> listOfCards)
        {
            ChanceCard cardDrawn = listOfCards.Dequeue();
            listOfCards.Enqueue(cardDrawn);
            return cardDrawn;
        }
    }
}

namespace Monopoly.GameLogic
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    using Monopoly;
    using Monopoly.Cards;
    using Monopoly.Dices;
    using Monopoly.Exceptions;
    using Monopoly.Interfaces;
    using Monopoly.Players;
    

    public class GameManager
    {
        private const int DiceMinValue = 1;
        private const int DiceMaxValue = 6;
        private const int PositionsOnBoard = 40;
        private const int CycleCash = 200;
        private const int JailPosition = 10;
        private static GameManager instance;
        private IDrawingEngine drawEngine;
        private IDice dice;
        private IList<IDice> dicesLog;

        private GameManager(IDrawingEngine drawEngine)
        {
            this.DrawEngine = drawEngine;
            this.dice = new Dices(19,50);
            this.dicesLog = new List<IDice>();
        }

        //SINGLETON DESIGN PATTERN
        public static GameManager GetInstance(IDrawingEngine drawEngine)
        {
            if (GameManager.instance == null)
            {
                GameManager.instance = new GameManager(drawEngine);
            }

            return GameManager.instance;
        }

        public IDrawingEngine DrawEngine
        {
            get
            {
                return this.drawEngine;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("An implementation of the IDrawEngine class must be provided.");
                }

                this.drawEngine = value;
            }
        }

        private IDice Dice
        {
            get
            {
                return this.dice;
            }

            set
            {
                this.dice = value;
            }
        }

        public void Game(Player[] players)
        {

            int pairs = 0;
            IList<Space> listOfSpaces = FieldInitializator.GetField();
            var communityChestSpaceObject = listOfSpaces.FirstOrDefault(s => s is CommunityChestSpace) as CommunityChestSpace;
            var chanceSpaceObject = listOfSpaces.FirstOrDefault(s => s is ChanceSpace) as ChanceSpace;

            this.DrawEngine.ClearScreen();
            int currentPlayerCounter = 0;

            //While LOOP for the game logic - it iterates over each player
            this.DrawEngine.DrawField();
            while (true)
            {

                //this.DrawEngine.DrawDices(dices.FirstDiceValue, dices.SecondDiceValue);
                //this.DrawEngine.DrawText(80, 50, string.Format("{0} {1}", this.Dice.FirstDiceValue, this.Dice.SecondDiceValue));


                var player = players[currentPlayerCounter];
                this.DrawEngine.DrawText(52, 13, "Player : " + player.ToString() + "'s turn");
                this.DrawEngine.DrawText(45, 15, "Press ENTER key to throw dices");
                Console.ReadLine();
                this.drawEngine.DrawText(45, 15, new string(' ', 35));
                this.dice.ThrowDices();
                this.dice.FirstDiceValue += 1;
                this.dice.SecondDiceValue += 1;

                this.dicesLog.Add(dice);
                if (this.Dice.FirstDiceValue == this.Dice.SecondDiceValue)
                {
                    pairs++;
                    if (pairs == 3)
                    {
                        player.IsInJail = true;
                        player.Position = GameManager.JailPosition;
                        continue;
                    }                    
                }
                else if (player.IsInJail==true)
                {
                    continue;
                }

                player.Position = (player.Position + this.Dice.FirstDiceValue + this.Dice.SecondDiceValue) % listOfSpaces.Count;
                //Defining which player's turn is
               
                MovePlayer(player);

                if (player.Position > PositionsOnBoard - 1)
                {
                    player.Position = player.Position - PositionsOnBoard;
                    player.AddCash(CycleCash);
                }
                //Definig where this player is
                var currentSpace = listOfSpaces[player.Position];

                CheckSpaces(players, listOfSpaces, communityChestSpaceObject,
                    chanceSpaceObject, currentPlayerCounter, player, currentSpace);

                //TODO:PLAYER WANTS TO BUILD HOUSES AND HOTEL SOMEWHERE     

                if (this.Dice.FirstDiceValue != this.Dice.SecondDiceValue)
                {
                    currentPlayerCounter++;
                    if (currentPlayerCounter > players.Length - 1)
                    {
                        currentPlayerCounter = 0;
                    }
                }
            }
        }

        private void MovePlayer(Player player)
        {
            Position oldPosition = new Position(player.PosX,player.PosY);            
            if (player.Position <= 10)
            {  
                player.PosX = 110 + player.PlayerNumber - player.Position * 11;
                player.PosY = 72;            
            }

            else if (player.Position > 10 && player.Position < 20)
            {  
                player.PosX=player.PlayerNumber;
                player.PosY=72 - (player.Position - 10) * 7;
            }
            else if (player.Position == 20)
            {  
                player.PosX = player.PlayerNumber;
                player.PosY = 1;
            }
            else if (player.Position >= 21 && player.Position < 30)
            {                
                player.PosX = player.PlayerNumber + (player.Position - 20) * 11;
                player.PosY = 7;
            }
            else if (player.Position > 30 && player.Position < 40)
            { 
                player.PosX = 110 + player.PlayerNumber;
                player.PosY = 2 + (player.Position - 30) * 7;
            }

            this.DrawEngine.DrawPlayer(player, oldPosition);
        }



        private void CheckSpaces(Player[] players, IList<Space> listOfSpaces, CommunityChestSpace CommunityChestSpaceObject, ChanceSpace ChanceSpaceObject, int currentPlayerCounter, Player player, Space currentSpace)
        {
            //Case if the Player stepped on a property space
            if (currentSpace is PropertySpace)
            {
                SteppedOnPropertySpace(players, listOfSpaces, currentPlayerCounter, player, currentSpace);
            }
            //Case if the Player stepped on a Utility space
            if (currentSpace is UtilitySpace)
            {
                SteppedOnUtilitySpace(players, listOfSpaces, currentPlayerCounter, player, currentSpace);
            }
            //Case if the Player stepped on a RailRoad space
            if (currentSpace is RailRoad)
            {
                SteppedOnRailRoadSpace(players, listOfSpaces, currentPlayerCounter, player, currentSpace);
            }
            //Case if the Player stepped on a Chance space
            if (currentSpace is ChanceSpace)
            {
                SteppedOnChanceSpace(players, listOfSpaces, CommunityChestSpaceObject, ChanceSpaceObject,
                    currentPlayerCounter, player, currentSpace);
            }
            //Case if the Player stepped on a Community Chest Space
            if (currentSpace is CommunityChestSpace)
            {
                SteppedOnCommunityChestSpace(players, listOfSpaces, CommunityChestSpaceObject, ChanceSpaceObject,
                    currentPlayerCounter, player, currentSpace);
            }
            if (currentSpace is Tax)
            {
                Tax currentTaxSpace = (Tax)currentSpace;
                player.RemoveCash(currentTaxSpace.TaxToPay);
            }
            if (currentSpace is GoToPrison)
            {
                player.Position = GameManager.JailPosition;
                currentSpace = listOfSpaces[player.Position];
                CheckSpaces(players, listOfSpaces, CommunityChestSpaceObject, ChanceSpaceObject, currentPlayerCounter, player, currentSpace);
            }           
            //TODO PLAYER IS ON JAIL SPACE            
        }

        private void SteppedOnChanceSpace(Player[] players, IList<Space> listOfSpaces,
            CommunityChestSpace CommunityChestSpaceObject, ChanceSpace ChanceSpaceObject,
            int currentPlayerCounter, Player player, Space currentSpace)
        {
            ChanceCard drawChanceCard = ChanceSpaceObject.DrawCard();
            if (drawChanceCard is SpaceCard)
            {
                SpaceCard drawChanceCardAsSpaceCard = drawChanceCard as SpaceCard;
                player.Position = drawChanceCardAsSpaceCard.PositionToGo;
                currentSpace = listOfSpaces[player.Position];
                CheckSpaces(players, listOfSpaces, CommunityChestSpaceObject, ChanceSpaceObject, currentPlayerCounter, player, currentSpace);
            }
            if (drawChanceCard is MoveCard)
            {
                MoveCard drawChanceCardAsMoveCard = drawChanceCard as MoveCard;
                player.Position = drawChanceCardAsMoveCard.SquaresToMove + player.Position;
                currentSpace = listOfSpaces[player.Position];
                CheckSpaces(players, listOfSpaces, CommunityChestSpaceObject, ChanceSpaceObject, currentPlayerCounter, player, currentSpace);
            }
            if (drawChanceCard is GoodLuckCard)
            {
                GoodLuckCard drawChanceCardAsMoveCard = drawChanceCard as GoodLuckCard;
                player.AddCash((int)drawChanceCardAsMoveCard.Cash);
            }
        }

        private void SteppedOnCommunityChestSpace(Player[] players, IList<Space> listOfSpaces,
            CommunityChestSpace CommunityChestSpaceObject, ChanceSpace ChanceSpaceObject, int currentPlayerCounter,
            Player player, Space currentSpace)
        {
            ChanceCard drawCommunityChestCard = CommunityChestSpaceObject.DrawCard();
            if (drawCommunityChestCard is SpaceCard)
            {
                SpaceCard drawChanceCardAsSpaceCard = drawCommunityChestCard as SpaceCard;
                player.Position = drawChanceCardAsSpaceCard.PositionToGo;
                currentSpace = listOfSpaces[player.Position];
                CheckSpaces(players, listOfSpaces, CommunityChestSpaceObject, ChanceSpaceObject, currentPlayerCounter, player, currentSpace);
            }
            if (drawCommunityChestCard is MoveCard)
            {
                MoveCard drawChanceCardAsMoveCard = drawCommunityChestCard as MoveCard;
                player.Position = drawChanceCardAsMoveCard.SquaresToMove + player.Position;
                currentSpace = listOfSpaces[player.Position];
                CheckSpaces(players, listOfSpaces, CommunityChestSpaceObject, ChanceSpaceObject, currentPlayerCounter, player, currentSpace);
            }
            if (drawCommunityChestCard is GoodLuckCard)
            {
                GoodLuckCard drawChanceCardAsMoveCard = drawCommunityChestCard as GoodLuckCard;
                player.AddCash((int)drawChanceCardAsMoveCard.Cash);
            }
        }

        private void SteppedOnRailRoadSpace(Player[] players, IList<Space> listOfSpaces, int currentPlayerCounter, Player player, Space currentSpace)
        {
            RailRoad currentRailroadSpace = (RailRoad)currentSpace;
            if (currentRailroadSpace.Owned == false)
            {
                FreeSpace(players, listOfSpaces, currentPlayerCounter, player, currentRailroadSpace);
                player.OwnedStations = currentRailroadSpace.Owned == true ?
                    player.OwnedStations + 1 :
                    player.OwnedStations;
            }
            else if (currentRailroadSpace.Owned == true &&
              !player.ListOfProperties.Contains(listOfSpaces[player.Position]))
            {
                OtherPlayerOwnRailRoad(players, listOfSpaces, player, currentRailroadSpace);
            }
        }

        private void SteppedOnUtilitySpace(Player[] players, IList<Space> listOfSpaces, int currentPlayerCounter, Player player, Space currentSpace)
        {
            UtilitySpace currentUtilitySpace = (UtilitySpace)currentSpace;
            if (currentUtilitySpace.Owned == false)
            {
                FreeSpace(players, listOfSpaces, currentPlayerCounter, player, currentUtilitySpace);
                player.OwnedUtilities = currentUtilitySpace.Owned == true ?
                    player.OwnedUtilities + 1 :
                    player.OwnedUtilities;
            }
            else if (currentUtilitySpace.Owned == true &&
              !player.ListOfProperties.Contains(listOfSpaces[player.Position]))
            {
                OtherPlayerOwnUtility(players, listOfSpaces, player, currentUtilitySpace);
            }
        }

        private void SteppedOnPropertySpace(Player[] players, IList<Space> listOfSpaces, int currentPlayerCounter, Player player, Space currentSpace)
        {
            PropertySpace currentPropertySpace = (PropertySpace)currentSpace;
            if (currentPropertySpace.Owned == false)
            {
                FreeSpace(players, listOfSpaces, currentPlayerCounter, player, currentPropertySpace);
            }
            else if (currentPropertySpace.Owned == true &&
                !player.ListOfProperties.Contains(listOfSpaces[player.Position]))
            {
                OtherPlayerOwn(players, listOfSpaces, player, currentPropertySpace);
            }

        }

        private void OtherPlayerOwnUtility(Player[] players, IList<Space> listOfSpaces, Player player, UtilitySpace currentUtilitySpace)
        {
            for (int i = 0; i < players.Length; i++)
            {
                var otherPlayer = players[i];
                if (otherPlayer.ListOfProperties.Contains(listOfSpaces[player.Position]))
                {
                    PayingMoney(player, (int)currentUtilitySpace.Rent * otherPlayer.OwnedUtilities, otherPlayer);
                }
            }
        }

        private void OtherPlayerOwnRailRoad(Player[] players, IList<Space> listOfSpaces, Player player, RailRoad currentRailRoadSpace)
        {
            for (int i = 0; i < players.Length; i++)
            {
                var otherPlayer = players[i];
                if (otherPlayer.ListOfProperties.Contains(listOfSpaces[player.Position]))
                {
                    PayingMoney(player, (int)currentRailRoadSpace.Rent * otherPlayer.OwnedStations, otherPlayer);
                }
            }
        }

        //Method for FREE PROPERTY SPACE - player has to make decision whether he want to buy it or not
        private void FreeSpace(Player[] players, IList<Space> listOfSpaces, int currentPlayer, Player player, PurchasableSpace currentPropertySpace)
        {
            this.DrawEngine.DrawText(40, 30, "Player to decide - buy(1) OR pass(2) : ");
            bool isInvalidInput=true;
            int decision = 0;
            do
            {
                try
                {
                    decision = int.Parse(Console.ReadLine());
                    if (decision < 1 || decision > 2)
                    {
                        throw new InvalidPlayerChoiceException();
                    }
                }
                catch (InvalidPlayerChoiceException ex)
                {
                    this.DrawEngine.DrawText(40, 32, ex.Message);
                    continue;
                }
                isInvalidInput = false;
            } while (isInvalidInput);
            this.DrawEngine.DrawText(40, 32, new string(' ', 30));


            if (decision == 1)
            {
                if (player.Bankroll < currentPropertySpace.BuyingPrice)
                {
                    this.DrawEngine.DrawText(40, 30, "Not Enough Money To Buy The Property");
                }
                else
                {
                    player.Bankroll = player.Bankroll - (int)currentPropertySpace.BuyingPrice;
                    player.AddSpace(currentPropertySpace);
                    currentPropertySpace.Owned = true;
                }
            }
            
        }

        //IF someone else OWNS THE SPACE - player has to PAY
        private void OtherPlayerOwn(Player[] players, IList<Space> listOfSpaces, Player player, PropertySpace currentPropertySpace)
        {
            for (int i = 0; i < players.Length; i++)
            {
                var otherPlayer = players[i];
                if (otherPlayer.ListOfProperties.Contains(listOfSpaces[player.Position]))
                {
                    if (currentPropertySpace.NumberOfhouses == 0 && currentPropertySpace.Hotel == 0)
                    {
                        PayingMoney(player, (int)currentPropertySpace.Rent, otherPlayer);
                    }
                    else if (currentPropertySpace.NumberOfhouses == 1 && currentPropertySpace.Hotel == 0)
                    {
                        PayingMoney(player, (int)currentPropertySpace.RentWithOneHouse, otherPlayer);
                    }
                    else if (currentPropertySpace.NumberOfhouses == 2 && currentPropertySpace.Hotel == 0)
                    {
                        PayingMoney(player, (int)currentPropertySpace.RentWithTwoHouses, otherPlayer);
                    }
                    else if (currentPropertySpace.NumberOfhouses == 3 && currentPropertySpace.Hotel == 0)
                    {
                        PayingMoney(player, (int)currentPropertySpace.RentWithThreeHouses, otherPlayer);
                    }
                    else if (currentPropertySpace.NumberOfhouses == 4 && currentPropertySpace.Hotel == 0)
                    {
                        PayingMoney(player, (int)currentPropertySpace.RentWithFourHouses, otherPlayer);
                    }
                    else if (currentPropertySpace.NumberOfhouses == 0 && currentPropertySpace.Hotel == 1)
                    {
                        PayingMoney(player, (int)currentPropertySpace.RentWithHotel, otherPlayer);
                    }
                }
            }
        }

        //THE ACTUAL PAYMENT is HERE
        private void PayingMoney(Player player, int moneyToPay, Player otherPlayer)
        {

            if (player.Bankroll - moneyToPay < 0)
            {
                Console.WriteLine("Do you want to see your properties:");
                Console.WriteLine("Yes(1) or No(2)");
                int decision = int.Parse(Console.ReadLine());
                while (true)
                {
                    if (decision != 1 && decision != 2)
                    {
                        Console.WriteLine("Try again to choose.");
                        decision = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                }

                if (decision == 1)
                {
                    ShowPlayerProperties(player);
                    int mortgagePropertiesValue = 0;
                    while (player.Bankroll + mortgagePropertiesValue - moneyToPay < 0)
                    {
                        Console.WriteLine("Enter the numbers in list the Properties to mortgage (ex. 1,2...):");
                        string inputNumbers = Console.ReadLine();
                        int[] propertiesToMortgage = inputNumbers.Split(new char[] { ',' },
                            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                        for (int i = 0; i < propertiesToMortgage.Length; i++)
                        {
                            mortgagePropertiesValue = mortgagePropertiesValue + (int)player.ListOfProperties[propertiesToMortgage[i]].MortgageValue;
                        }

                        if (player.Bankroll + mortgagePropertiesValue - moneyToPay >= 0)
                        {
                            for (int j = 0; j < propertiesToMortgage.Length; j++)
                            {
                                player.ListOfProperties[propertiesToMortgage[j]].Mortgaged = true;
                                player.Bankroll = player.Bankroll + (int)player.ListOfProperties[propertiesToMortgage[j]].MortgageValue;
                            }

                            player.RemoveCash(moneyToPay);
                            otherPlayer.AddCash(moneyToPay);
                        }
                        else if (player.Bankroll + mortgagePropertiesValue - moneyToPay < 0
                            && propertiesToMortgage.Length < player.ListOfProperties.Count)
                        {
                            mortgagePropertiesValue = 0;
                        }
                        else
                        {
                            //TO DO: player is bankrupt
                        }
                    }
                }
            }
            else
            {
                player.RemoveCash(moneyToPay);
                otherPlayer.AddCash(moneyToPay);
            }

        }

        private void ShowPlayerProperties(Player player)
        {
            for (int i = 0; i < player.ListOfProperties.Count; i++)
            {
                Console.WriteLine("Number in List:{0} Name:{1} Price:{2} ", i + 1,
                    player.ListOfProperties[i].Name, player.ListOfProperties[i].BuyingPrice);
                Console.WriteLine("Selling Price:{0} Mortgaged:{1}", player.ListOfProperties[i].SellingPrice, player.ListOfProperties[i].Mortgaged);
                Console.WriteLine("Mortgage value:{0}", player.ListOfProperties[i].MortgageValue);
                Console.WriteLine("-----------------");
            }
        }
    }
}



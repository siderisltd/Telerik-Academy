namespace Monopoly
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Monopoly.Players;

    public class Bank : Element
    {
        private List<PurchasableSpace> purchasableSpaces = new List<PurchasableSpace>();
        private double money = 20580;  //initial amount of money in the bank

        public Bank()
        {
            //throw new System.NotImplementedException();
        }
        public Bank(int money)
        {
            this.money = money;
        }

        public void GetMoney(int price)
        {
            this.money = money + price;
        }

        public void GiveMoney(int bonus)
        {
            this.money = money - bonus;
        }

        //public void AddSpace()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void RemoveSpace()
        //{
        //    throw new System.NotImplementedException();
        //}

        public void Auction(List<PropertySpace> properties, List<Player> players)
        {
            Dictionary<int, int> offers = new Dictionary<int, int>();

            foreach (PropertySpace item in properties)
            {
                for (int i = 0; i < players.Count(); i++)
                {
                    Console.WriteLine("Player number {0}", i + 1);
                    int bid = Int16.Parse(EncryptBids());
                    offers.Add(players[i].PlayerNumber, bid);
                }

                int maxBid = offers.Max(kvp => kvp.Value); //namira nai-golqmata oferta
                //namira syotvetniq igrach,
                //ako ima ednakvi oferti, prodava na pyrviqt igrach po nomer, tyi kato toi pyrvi e predlojil tazi cena
                int playerNumber = offers.FirstOrDefault(x => x.Value == maxBid).Key;

                players[playerNumber - 1].RemoveCash(maxBid);
                //Console.WriteLine("MaxBid {0}", maxBid);
                players[playerNumber].AddSpace(item);
                GetMoney(maxBid);
                //Console.WriteLine("Bank money {0}", money);
            }
        }

        public string EncryptBids()
        {
            Console.WriteLine("Please, give your bid for this property");

            string bidToString = "";

            //ConsoleKeyInfo info = Console.ReadKey(true);
            //while (info.Key != ConsoleKey.Enter)
            //{
            //    if (info.Key != ConsoleKey.Backspace)
            //    {
            //        Console.Write("*");
            //        password += info.KeyChar;
            //    }
            //    else if (info.Key == ConsoleKey.Backspace)
            //    {
            //        if (!string.IsNullOrEmpty(password))
            //        {
            //            // remove one character from the list of password characters
            //            password = password.Substring(0, password.Length - 1);
            //            // get the location of the cursor
            //            int pos = Console.CursorLeft;
            //            // move the cursor to the left by one character
            //            Console.SetCursorPosition(pos - 1, Console.CursorTop);
            //            // replace it with space
            //            Console.Write(" ");
            //            // move the cursor to the left by one character again
            //            Console.SetCursorPosition(pos - 1, Console.CursorTop);
            //        }
            //    }
            //    info = Console.ReadKey(true);
            //}

            // add a new line because user pressed enter at the end of their password
            Console.WriteLine();
            return bidToString;
        }

        public void GetJailTax()
        {
            this.money = money + 50;
        }

        public void AddMortgage(int mortgage)
        {
            this.money = money - mortgage;
        }

        public void RemoveMortgage(int mortgage)
        {
            this.money = money + mortgage + (mortgage * 0.1);
        }

        public void GetMortgageTax(int mortgage)
        {
            this.money = money + mortgage * 0.1;
        }
    }
}

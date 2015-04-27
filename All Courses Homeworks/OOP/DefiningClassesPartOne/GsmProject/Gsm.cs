namespace GsmProject
{
    using System;
    using System.Collections.Generic;

    public class Gsm
    {
        public static Gsm IPhone4S = new Gsm 
        {
            Model = "Iphone 4S", 
            Manufacturer = "Apple",
            Price = 345.65,
            Owner = "Vivacom",
            HoursIdle = 20,
            HoursTalk = 50,
            BatteryModel = "GXC10234",
            TypeOfBattery = BatteryType.LiIon,
            DisplayColors = 16000000,
            DisplayDimensions = "10x16"
        };

        private const decimal PriceForCall = 0.37M;
        private Battery battery;
        private Display display;
        private Call call;
        private List<Call> callHistory = new List<Call>();
        private List<decimal> callPrice = new List<decimal>();

        public Gsm()
        {
            this.battery = new Battery();
            this.display = new Display();
            this.call = new Call();
        }

        public Gsm(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.battery = new Battery();
            this.display = new Display();
        }

        public Gsm(string model, string manufacturer, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.battery = battery;
            this.display = display;
            this.call = new Call();
        }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public double Price { get; set; }

        public string Owner { get; set; }

        public double HoursIdle
        {
            get { return this.battery.HoursIdle; }
            set { this.battery.HoursIdle = value; }
        }

        public int CallDuration
        {
            get
            { 
                return this.call.CallDuration; 
            }

            set 
            {
                this.call.CallDuration = value;
                if (this.call.CallDuration != 0 && this.call.PhoneNumber != 0)
                {
                    this.callHistory.Add(this.call);
                    this.callPrice.Add(this.call.CallDuration * PriceForCall);
                    this.call = new Call();
                }
            }
        }

        public ulong PhoneNumber
        {
            get 
            { 
                return this.call.PhoneNumber;
            }

            set 
            {
                this.call.PhoneNumber = value;
                if (this.call.CallDuration != 0 && this.call.PhoneNumber != 0)
                {
                    this.callHistory.Add(this.call);
                    this.callPrice.Add(this.call.CallDuration * PriceForCall);
                    this.call = new Call();
                }
            }
        }

        public double HoursTalk
        {
            get { return this.battery.HoursTalk; }
            set { this.battery.HoursTalk = value; }
        }

        public string BatteryModel
        {
            get { return this.battery.Model; }
            set { this.battery.Model = value; }
        }

        public BatteryType TypeOfBattery
        {
            get { return this.battery.BatteryType; }
            set { this.battery.BatteryType = value; }
        }

        public string DisplayDimensions
        {
            get { return this.display.Size; }
            set { this.display.Size = value; }
        }

        public ulong DisplayColors
        {
            get { return this.display.NumberOfColors; }
            set { this.display.NumberOfColors = value; }
        }

        public override string ToString()
        {
            Console.WriteLine("[Phone Characteristics]");
            Console.WriteLine();
            Console.WriteLine("Phone model : " + this.Model);
            Console.WriteLine("Phone manufacturer : " + this.Manufacturer);
            Console.WriteLine("Phone Price : " + this.Price);
            Console.WriteLine("Phone Owner : " + this.Owner);
            Console.WriteLine();
            Console.WriteLine("[Display Characteristics]");
            Console.WriteLine();
            Console.WriteLine("Display Size : " + this.display.Size);
            Console.WriteLine("Display Colors : " + this.display.NumberOfColors);
            Console.WriteLine();
            Console.WriteLine("[Battery Characteristics]");
            Console.WriteLine();
            Console.WriteLine("Battery type : " + this.battery.BatteryType);
            Console.WriteLine("Battery Model : " + this.battery.Model);
            Console.WriteLine("Hours Idle : " + this.battery.HoursIdle);
            Console.WriteLine("Hours Talk : " + this.battery.HoursTalk);
            return base.ToString();
        }

        public void DeleteCall()
        {
            if (this.callHistory[0] != null)
            {
                Console.WriteLine("You can delete the following calls from [{0}] to [{1}] which are as follows");
                Console.WriteLine();
                Console.WriteLine("Call History");
                Console.WriteLine();
                for (int i = 0; i < this.callHistory.Count; i++)
                {
                    Console.WriteLine("[" + (int)(i + 1)  + "] ");
                    Console.WriteLine();
                    this.DisplayCall(this.callHistory[i]);
                    Console.WriteLine("Call price : " + callPrice[i] + "USD");
                    Console.WriteLine();
                }

                Console.Write("Press it's number : ");
                int num = int.Parse(Console.ReadLine());
                this.callHistory.RemoveAt(num - 1);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There are no calls to delete");
            }
        }

        public void DisplayCallHistory()
        {
            if (this.callHistory[0] != null)
            {
                Console.WriteLine("Call History");
                for (int i = 0; i < this.callHistory.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[" + (int)(i + 1) + "] ");
                    Console.WriteLine();
                    this.DisplayCall(this.callHistory[i]);
                    Console.WriteLine("Call price : " + callPrice[i] + "USD");
                }
            }
            else
            {
                Console.WriteLine("There are no calls to display");
            }
        }

        public void TotalCallPrices()
        {
            if (this.callPrice[0] != 0)
            {
                decimal totalCost = 0;
                foreach (var phoneCallCost in this.callPrice)
                {
                    totalCost += phoneCallCost;
                }
                Console.WriteLine("Total Cost : {0} USD", totalCost);
            }
            else
            {
                Console.WriteLine("There are no calls !");
            }
        }

        private void DisplayCall(Call call)
        {
            Console.WriteLine("Call Date : " + call.CallDate);
            Console.WriteLine("Call Duration : " + call.CallDuration);
            Console.WriteLine("Call PhoneNumber : " + call.PhoneNumber);
            Console.WriteLine();
        }

    }
}

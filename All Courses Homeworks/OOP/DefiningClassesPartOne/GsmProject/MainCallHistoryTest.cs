namespace GsmProject
{
    using System;

    public class MainCallHistoryTest
    {
        public static void Main()
        {
            #region testObject
            Gsm samsungMini = new Gsm();
            samsungMini.TypeOfBattery = BatteryType.NiCD;
            samsungMini.BatteryModel = "HGX4736BG";
            samsungMini.DisplayColors = 6000000;
            samsungMini.DisplayDimensions = "3x8";
            samsungMini.HoursIdle = 12;
            samsungMini.HoursTalk = 40;
            samsungMini.Manufacturer = "Samsung";
            samsungMini.Owner = "Ralica";
            samsungMini.Price = 5;
            samsungMini.Model = "Samsung Mini Galaxy S2";
            #endregion testObject

            //adding calls to this test object

            samsungMini.CallDuration = 5;
            samsungMini.PhoneNumber = 5454545;

            samsungMini.CallDuration = 1222;
            samsungMini.PhoneNumber = 54231235;

            samsungMini.CallDuration = 23233;
            samsungMini.PhoneNumber = 532423424234;

            samsungMini.CallDuration = 13443422;
            samsungMini.PhoneNumber = 54233423421235;

            samsungMini.CallDuration = 1222;
            samsungMini.PhoneNumber = 54231235;

            samsungMini.CallDuration = 99999999;
            
                               //These are the available methods you can use for testing this program


            //GsmTest test = new GsmTest();
            //test.GetGsmsInfo();

            //Gsm.IPhone4S.ToString();

            //samsungMini.DeleteCall();
            //
            //samsungMini.DisplayCallHistory();
            //
            //samsungMini.TotalCallPrices();
        }
    }
}

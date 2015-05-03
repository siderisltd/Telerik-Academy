namespace GsmProject
{
    public class GsmTest
    {
        private Gsm[] gsms;

        public GsmTest()
        {
            this.gsms = new Gsm[3];
            this.gsms[0] = new Gsm();
            this.gsms[0].TypeOfBattery = BatteryType.NiCD;
            this.gsms[0].BatteryModel = "HGX4736BG";
            this.gsms[0].DisplayColors = 6000000;
            this.gsms[0].DisplayDimensions = "3x8";
            this.gsms[0].HoursIdle = 12;
            this.gsms[0].HoursTalk = 40;
            this.gsms[0].Manufacturer = "Samsung";
            this.gsms[0].Owner = "Mtel";
            this.gsms[0].Price = 5;
            this.gsms[0].Model = "Samsung Mini Galaxy S2";
            this.gsms[1] = new Gsm();
            this.gsms[1] = new Gsm("Alcatel Scribe HD", "Alcatel", new Battery(), new Display());
            this.gsms[2] = new Gsm();
            this.gsms[2] = new Gsm("Cat", "Cat Inc");
        }

        public void GetGsmsInfo()
        {
            foreach (var gsm in this.gsms)
            {
                gsm.ToString();
                System.Console.WriteLine();
            }
        }
    }
}

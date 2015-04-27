namespace GsmProject
{
    public enum BatteryType
    {
        Unknown,
        LiIon,
        NiMH,
        NiCD
    }

    public class Battery
    {
        public Battery()
        {
        }

        public string Model { get; set; }

        public double HoursIdle { get; set; }

        public double HoursTalk { get; set; }

        internal BatteryType BatteryType { get; set; }
    }
}

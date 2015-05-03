namespace GsmProject
{
    using System;

    public class Call
    {
        private DateTime callDate = DateTime.Now;

        public Call()
        {
            this.callDate = DateTime.Now;
        }

        public Call(int callDuration, ulong phoneNumber)
        {
            this.callDate = DateTime.Now;
            this.PhoneNumber = phoneNumber;
            this.CallDuration = callDuration;
        }

        public DateTime CallDate 
        {
            get 
            {
                return this.callDate;
            } 

            private set
            {
            }
        }

        public int CallDuration { get; set; }

        public ulong PhoneNumber { get; set; }
    }
}

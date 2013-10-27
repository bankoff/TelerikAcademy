using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile.Phones
{
    public class Call
    {
        private string dialedPhone;
        private int durationInSeconds;

        public Call(DateTime dateAndTime, string dialedPhone, int durationInSeconds)
        {
            this.DateAndTime = dateAndTime;
            this.DialedPhone = dialedPhone;
            this.DurationInSeconds = durationInSeconds;
        }

        public DateTime DateAndTime { get; set; }

        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set
            {
                if (value.Length >= 3)
                {
                    this.dialedPhone = value;
                }
                else
                {
                    Console.WriteLine("The length of the dialed phone should contain at least 3 characters!");
                }
            }
        }

        public int DurationInSeconds
        {
            get { return this.durationInSeconds; }
            set
            {
                if (value > 0)
                {
                    this.durationInSeconds = value;
                }
                else
                {
                    Console.WriteLine("The duration should be at least one second!");
                }
            }
        }

        public override string ToString()
        {
            string result = String.Format("Date and Time: " + this.DateAndTime + "\nDialed phone " + this.DialedPhone +
                "\nDuration in seconds: " + this.DurationInSeconds);
            return result;
        }
    }
}
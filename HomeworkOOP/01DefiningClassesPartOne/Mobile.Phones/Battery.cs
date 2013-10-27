using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile.Phones
{
    public class Battery
    {
        private string modelBattery;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType? type;

        public Battery(string modelBattery=null, double? hoursIdle=null, double? hoursTalk=null, BatteryType? type=null)
        {
            this.ModelBattery = modelBattery;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }

        public BatteryType? Type
        {
            get { return type; }
            set { type = value; }
        }

        public double? HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value > 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    System.Console.WriteLine("Hours talk time should be positive number!");
                }
            }
        }

        public double? HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if (value > 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    System.Console.WriteLine("Hours idle time should be positive number!");
                }
            }
        }

        public string ModelBattery
        {
            get { return modelBattery; }
            set
            {
                if (value.Length > 0)
                {
                    this.modelBattery = value;
                }
                else
                {
                    System.Console.WriteLine("Model should contain at least one character!");
                }
            }
        }

    }
}
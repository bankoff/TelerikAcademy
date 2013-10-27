using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile.Phones
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private Person owner;
        private Battery battery;
        private Display display;
        private static GSM iPhone4S;
        private List<Call> callHistory;

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal? price=null, Person owner=null, Battery battery=null, Display display=null)
            :this(model,manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

        public static GSM IPhone4S
        {
            get
            {

                if (iPhone4S == null)
                {
                    iPhone4S = new GSM("4S", "Iphone",102.98m);
                    iPhone4S.Battery = new Battery("4R87", 12.3, 3.5, BatteryType.NiMH);
                    iPhone4S.Display = new Display(7.8, 256000);
                }

                return iPhone4S;
            }
        }

        public Display Display
        {
            get { return display; }
            set { display = value; }
        }

        public Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        public Person Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public decimal? Price
        {
            get { return price; }
            set
            {
                decimal result;
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    if (Decimal.TryParse(value.ToString(), out result) || result > 0m)
                    {
                        this.price = result;
                    }
                    else
                    {
                        throw new ArgumentException("Price is not valid");
                    }
                }
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentException("Input for mobile manufacturer is not valid");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Input for mobile model is not valid");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Model: " + this.Model);
            result.AppendLine("Manufacturer: " + this.Manufacturer);

            if (this.Price != null)
            {
                result.AppendLine("Price: " + this.Price);
            }

            if (this.Owner != null)
            {
                result.AppendLine("Owner: " + this.Owner.Name);
            }
            if (this.Battery != null)
            {
                result.AppendLine("Battery:  " + "model-" + this.Battery.ModelBattery
                                                + "  hours idle-" + this.Battery.HoursIdle
                                                + "  hours talk-" + this.Battery.HoursTalk
                                                + "  battery type-" + this.Battery.Type);
            }
            if (this.Display != null)
            {
                result.AppendLine("Display:" + "  size-" + this.Display.DisplaySize + "  colors-" + this.Display.DisplayColors);
            }

            return result.ToString();
        }

        //Calls methods
        public void AddCall(Call call)
        {
            if (CallHistory == null)
            {
                CallHistory = new List<Call>();
            }
            this.CallHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearHistory(List<Call> CallHistory)
        {
            CallHistory.Clear();
        }

        public decimal CalculatePrice(decimal pricePerMinute)
        {
            decimal timeTalked = 0;
            foreach (var call in callHistory)
            {
                timeTalked += call.DurationInSeconds;
            }

            decimal totalMoney = (pricePerMinute / 60) * timeTalked;
            return Math.Round(totalMoney,2);
        }
    }
}
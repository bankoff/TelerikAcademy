using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile.Phones
{
    public class Display
    {
        private double? displaySize;
        private int? displayColors;

        public Display(double? displaySyze=null, int? displayColors=null)
        {
            this.DisplaySize = displaySyze;
            this.DisplayColors = displayColors;
        }

        public int? DisplayColors
        {
            get { return displayColors; }
            set
            {
                if (value > 0)
                {
                    this.displayColors = value;
                }
                else
                {
                    System.Console.WriteLine("Number of colors should be positive integer, bigger than 0!");
                }
            }
        }
        
        public double? DisplaySize
        {
            get { return displaySize; }
            set
            {
                if (value > 0)
                {
                    this.displaySize = value;
                }
                else
                {
                    System.Console.WriteLine("Size should be positive number!");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopSho_
{
    class Battery
    {
        private int cells;
        private int mah;
        private BatteryType batteryType;

        public Battery(int cells, int mah, BatteryType batteryType)
        {
            this.Cells = cells;
            this.Mah = mah;
            this.Type = batteryType;
        }

        public int Cells
        {
            get { return this.cells; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid battery cells input!");
                }
                this.cells = value;   
            }
        }

        public int Mah
        {
            get { return this.mah; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid battery mAh");
                }

                this.mah = value;
            }
        }

        public BatteryType Type
        {
            get { return this.batteryType; }

            set { this.batteryType = value; }
        }

        public override string ToString()
        {
            return $"{this.batteryType}, {this.cells}-cells, {this.mah} mAh";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace LaptopSho_
{
    class Laptop
    {
        private string model;
        private string manifacturer;
        private string processor;
        private string ram;
        private string graphic;
        private string hdd;
        private string screen;
        private Battery battery;
        private double batteryLife;
        private decimal price;

        public Laptop(string model, string manifacture, string processor, string ram,
            string graphic, string hdd, string screen, Battery battery,
            double batteryLife, decimal price)
        {
            this.Model = model;
            this.Manifacture = manifacturer;
            this.Proccesor = processor;
            this.Ram = ram;
            this.Graphic = graphic;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
            this.Price = price;
        }

        public Laptop (string model, string manifacture, string processor, string ram, double batteryLife, decimal price)
                    : this(model,manifacture,processor, ram,null,null,null,null,batteryLife, price)
        {
        }

        public Laptop(string model, decimal price)
            : this(model, null,null, null, 0, price)
        {
        }

        public Laptop()
        {
        }

        public string Model
        {
            get { return this.model; }

            set
            {
                if(value.Trim().Length == 0)
                {
                    throw new ArgumentException("Invalid Model. Entering Model is mandatory.");
                }

                this.model = value;
            }
        }

        public string Manifacture
        {
            get { return this.manifacturer; }

            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("Invalid Manifacturer");
                }

                this.manifacturer = value;
            }
        }

        public string Proccesor
        {
            get { return this.processor; }

            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("Processor name");
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get { return this.ram; }

            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("RAM entry");
                }
                this.ram = value;
            }
        }

        public string Graphic
        {
            get { return this.graphic; }

            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("Graphic card model");
                }
                this.graphic = value;
            }
        }

        public string HDD
        {
            get { return this.hdd; }

            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("HDD model");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }

            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("Screen model");
                }
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }

            set { this.battery = value; }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery Life entry");
                }
                this.batteryLife = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }

            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("Invalid price. Entering price is mandatory");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            string separator = "+" + new string('-',15) + "+" + new string('-', 65) + "+";
            StringBuilder output = new StringBuilder();
            output.AppendLine(separator);

            output.AppendLine($"|{"model",-15}|{this.model,-65}|");
            output.AppendLine(separator);

            if (manifacturer != null)
            {
                output.AppendLine($"|{"manifacturer",-15}|{this.manifacturer,-65}|");
                output.AppendLine(separator);
            }

            if (processor != null)
            {
                output.AppendLine($"|{"processor",-15}|{this.processor,-65}|");
                output.AppendLine(separator);
            }

            if (ram != null)
            {
                output.AppendLine($"|{"RAM",-15}|{this.ram,-65}|");
                output.AppendLine(separator);
            }

            if (graphic != null)
            {
                output.AppendLine($"|{"Graphic card",-15}|{this.graphic,-65}|");
                output.AppendLine(separator);
            }

            if (hdd != null)
            {
                output.AppendLine($"|{"HDD",-15}|{this.hdd,-65}|");
                output.AppendLine(separator);
            }

            if (screen != null)
            {
                output.AppendLine($"|{"Screen",-15}|{this.screen,-65}|");
                output.AppendLine(separator);
            }

            if (battery != null)
            {
                output.AppendLine($"|{"Battery",-15}|{this.battery,-65}|");
                output.AppendLine(separator);
            }

            if (batteryLife > 0)
            {
                output.AppendLine($"|{"Battery Life",-15}|{this.batteryLife,-65}|");
                output.AppendLine(separator);
            }

            output.AppendLine($"|{"price",-15}|{this.price,-65:C}|");
            output.AppendLine(separator);

            return output.ToString();
        }
    }
}

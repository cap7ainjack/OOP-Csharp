using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCcatalog
{
    class Component
    {
        private string name;
        private string details;
        private double price;

        public Component(string name, string details, double price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, double price) : this(name,null, price)
        {
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Component name cant be empty");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }

            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("Details field cant be empty");
                }

                this.details = value;
            }
        }

        public double Price
        {
            get { return this.price; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Component price cant be negative number");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            string seperator = "+" + new string('-', 15) + "+" + new string('-', 35) + "+";

            info.AppendLine(seperator);
            if (this.Details != null)
            {
                info.AppendLine($"|{"component name",15}|{this.Name + " (" + this.Details + ")",35}|");
            }
            else
            {
                info.AppendLine($"|{"component name",15}|{this.Name,35}|");
            }

            info.AppendLine($"|{"",15}|{this.Price,35:C}|");

            return info.ToString();
        }
    }
}

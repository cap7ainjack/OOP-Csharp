using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCcatalog
{
    class Computer
    {
        private string name;
        private List<Component> components;

        public Computer(string name, params Component[] components)
        { 
            this.Name = name;
            this.AddComponents(components);
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (value.Trim().Length < 0)
                {
                    throw new ArgumentException("Computer name is mandatory!");
                }
                this.name = value;
            }
        }

        public double Price
        {
            get { return this.components.Sum(component => component.Price); }
        }

        private void AddComponents(Component[] components )
        {
           this.components = new List<Component>();
            foreach (var comp in components)
            {
                this.components.Add(comp);
            }

        }

        public override string ToString()
        {
            var info = new StringBuilder();
            string seperator = "+" + new string('-', 15) + "+" + new string('-', 35) + "+";

            info.AppendLine(seperator);
            info.AppendLine($"|{"pc name",15}|{this.Name,35}|");

            foreach (var component in this.components)
            {
                info.Append(component);
            }
            info.AppendLine(seperator);
            info.AppendLine($"|{"total price",15}|{this.Price,35:c}|");
            info.AppendLine(seperator);

            return info.ToString();
        }
    }
}

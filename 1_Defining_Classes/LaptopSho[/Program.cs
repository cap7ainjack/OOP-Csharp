using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaptopSho_;

namespace LaptopShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop asusX100 = new Laptop("X100", "Asus", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                                        "16 GB", "Nvidia GeForce 7600", "128GB SSD",
                                        "13.3'(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display",
                                        new Battery(4, 2500,BatteryType.LiIon), 4.5,2200);

            Laptop lenovog570 = new Laptop("g570", 600);

            Console.WriteLine(asusX100);

        }
    }
}

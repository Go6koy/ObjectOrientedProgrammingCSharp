﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            Laptop lenovo = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)"
                , "8 GB", "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                "Li-Ion, 4-cells, 2550 mAh", "4.5 hours", 2259.00);
            Laptop hp = new Laptop("HP 250 G2", 699.00);
            Console.WriteLine(hp);
            Console.WriteLine(lenovo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class Refrigerator(string Brand,int Temperature)
    {
        public string? Brand { get; set; }
        public int Temperature { get; set; }
        string _brand = Brand;
        int _temperature = Temperature;
        public void StartCooling()
        {
            Console.WriteLine($"{_brand} refrigerator starts cooling.");
        }
        public void StopCooling() 
        {
            Console.WriteLine($"{_brand} refrigerator stops cooling.");
        }
        public void PrintCoolingEnergy()
        {
            Console.WriteLine($"{_brand} refrigerator uses 3.6 kWh per day.");
        }
    }

}

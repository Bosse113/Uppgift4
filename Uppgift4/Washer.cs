using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class Washer(string Brand,int CapacityKg)
    {
        public string? Brand { get; set; }
        public int CapacityKg { get; set; }
        string _brand=Brand;
        int _capacityKg=CapacityKg;

        public void StartWash()
        {
            Console.WriteLine($"{_brand} washer starts washing.");
        }
        public void StopWash() 
        { 
            Console.WriteLine($"{_brand} washer stops washing.");
        }
        public void PrintWashEnergy()
        {
            Console.WriteLine($"{_brand} washer uses 1.2 kWh per wash.");
        }
    }
}

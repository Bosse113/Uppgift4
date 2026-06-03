using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class Oven(string Brand, int MaxTemperature)
    {
        public string? Brand { get; set; }
        public int MaxTemperature { get; set; }
        string _brand=Brand;
        int _maxTemperature=MaxTemperature;

        public void StartHeating()
        {
            Console.WriteLine($"{_brand} oven starts heating.");
        }
        public void StopHeating() 
        { 
            Console.WriteLine($"{_brand} oven stops heating.");
        }
        public void PrintHeatingEnergy()
        {//ToDo
            Console.WriteLine($"{_brand} oven uses 2.5 kWh per hour.");
        }
    }
}

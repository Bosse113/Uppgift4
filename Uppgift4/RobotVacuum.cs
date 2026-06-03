using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class RobotVacuum(string Brand,int BatteryLevel)
    {
        public string Brand { get; set; }
        public int BatteryLevel { get; set; }
        string _brand=Brand;
        int _batteryLevel = BatteryLevel;

        public void StartCleaning()
        {
            Console.WriteLine($"{_brand} robot vacuum starts cleaning.");
        }

        public void StopCleaning() 
        {
            Console.WriteLine($"{_brand} robot vacuum stops cleaning.");
        }
        public void PrintCleaningEnergy()
        {
            Console.WriteLine($"{_brand} robot vacuum uses 0.4 kWh per cleaning. ");
        }
    }
}

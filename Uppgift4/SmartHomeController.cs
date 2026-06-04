using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class SmartHomeController
    {
        private List<Appliance> _devices = new List<Appliance>(); 
        public void AddDevice(Appliance device)
        { // TODO: 
          // Lägg till device i listan.
          _devices.Add(device); 
        }
        public void TurnOnAll()
        { // TODO: // Loopa igenom alla devices och starta dem. 
          // Du får inte använda if/switch på specifika klasser.
            foreach (Appliance device in _devices)
            {
                device.TurnOn();
            }
        }
        public void TurnOffAll()
        { // TODO: 
          // Loopa igenom alla devices och stäng av dem.
            foreach (Appliance device in _devices)
            {
                device.TurnOff();
            }
        }
        public void PrintStatusReport()
        { // TODO: 
          // Loopa igenom alla devices. 
          // Skriv ut GetInfo() och om apparaten är på eller av.
            foreach (Appliance device in _devices)
            {
                Console.WriteLine(device.GetInfo());
            }
        }
        public double GetTotalDailyEnergyUsage()
        { // TODO: 
          // Räkna ihop GetDailyEnergyUsage() för alla devices. 
          // Returnera totalsumman.
          double totalDailyEnergyUsage = 0;
            foreach (Appliance device in _devices)
            {
                totalDailyEnergyUsage+= device.GetDailyEnergyUsage();
            }
            return totalDailyEnergyUsage;
            throw new NotImplementedException();
        }
    } 
    
}

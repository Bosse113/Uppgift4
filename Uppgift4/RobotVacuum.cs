using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class RobotVacuum : Appliance
    {
        private double energyPerHour;
        private int BatteryLevel;

        public RobotVacuum(string brand, string room, double energyPerHour, int BatteryLevel)
            : base(brand, room)
        {
            this.energyPerHour = energyPerHour;
            this.BatteryLevel = BatteryLevel;
        }

        public override string GetInfo()
        {
            return $"RobotVacuum: {Brand} in {Room}";
        }

        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine($"RobotVacuum {Brand} starts vacuuming.");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine($"RobotVacuum ,{Brand}, is now off.");
        }

        public override double GetDailyEnergyUsage()
        {
            if (IsOn)
            {
                return energyPerHour ; 
            }

            return 0;
        }

        //internal class RobotVacuum(string Brand,int BatteryLevel)
        //{
        //    public string? Brand { get; set; }
        //    public int BatteryLevel { get; set; }
        //    string _brand=Brand;
        //    int _batteryLevel = BatteryLevel;

        //    public void StartCleaning()
        //    {
        //        Console.WriteLine($"{_brand} robot vacuum starts cleaning.");
        //    }

        //    public void StopCleaning() 
        //    {
        //        Console.WriteLine($"{_brand} robot vacuum stops cleaning.");
        //    }
        public void PrintCleaningEnergy()
        {
            Console.WriteLine($"{Brand} robot vacuum uses {energyPerHour} kWh per cleaning. ");
        }
    }
}

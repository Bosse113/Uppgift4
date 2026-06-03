using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class Oven : Appliance
    {
        private double energyPerHour;
        private int CupsPerBrew;

        public Oven(string brand, string room, double energyPerHour, int CupsPerBrew)
            : base(brand, room)
        {
            this.energyPerHour = energyPerHour;
            this.CupsPerBrew = CupsPerBrew;
        }

        public override string GetInfo()
        {
            return $"Refrigerator: {Brand} in {Room}";
        }

        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine($"{Brand} Refrigerator starts cooling.");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine($"Refrigerator ,{Brand}, has finished and is now off.");
        }

        public override double GetDailyEnergyUsage()
        {
            if (IsOn)
            {
                return energyPerHour;
            }

            return 0;
        }
    
    //internal class Oven(string Brand, int MaxTemperature)
    //{
    //    public string? Brand { get; set; }
    //    public int MaxTemperature { get; set; }
    //    string _brand=Brand;
    //    int _maxTemperature=MaxTemperature;

    //    public void StartHeating()
    //    {
    //        Console.WriteLine($"{_brand} oven starts heating.");
    //    }
    //    public void StopHeating() 
    //    { 
    //        Console.WriteLine($"{_brand} oven stops heating.");
    //    }
        public void PrintHeatingEnergy()
        {//ToDo
            Console.WriteLine($"{Brand} oven uses {energyPerHour} kWh per hour.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class Oven : Appliance
    {
        private double energyPerHour;
        private int MaxTemperature;

        public Oven(string brand, string room, double energyPerHour, int MaxTemperature)
            : base(brand, room)
        {
            this.energyPerHour = energyPerHour;
            this.MaxTemperature = MaxTemperature;
        }

        public Oven(string brand, string room, int maxTemperature) : base(brand, room)
        {
        }

        public override string GetInfo()
        {
            return $"Oven: {Brand} in {Room}";
        }

        public sealed override void TurnOn()
        {
            base.TurnOn();
            //Console.WriteLine($"Oven {Brand} starts cooling.");
        }

        public sealed override void TurnOff()
        {
            base.TurnOff();
            //Console.WriteLine($"Oven ,{Brand}, is now off.");
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
        //public void PrintHeatingEnergy()
        //{
        //    Console.WriteLine($"{Brand} oven uses {energyPerHour} kWh per hour.");
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Uppgift4
{
    internal class Refrigerator : Appliance
    {
        private double energyPerHour;
        private int Temperature;
        private string Cname = typeof(Refrigerator).Name;

        public Refrigerator(string brand, string room, double energyPerHour, int Temperature)
            : base(brand, room)
        {
            this.energyPerHour = energyPerHour;
            this.Temperature = Temperature;
        }

        public override string GetInfo()
        {
            return $"{Cname} {Brand} in {Room}";
        }

        public override void TurnOn()
        {
            base.TurnOn();
            //Console.WriteLine($"{Cname} {Brand} starts cooling.");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            //Console.WriteLine($"{Cname} ,{Brand}, is now off.");
        }

        public override double GetDailyEnergyUsage()
        {
            if (IsOn)
            {
                return energyPerHour ; 
            }

            return 0;
        }

    //internal class Refrigerator(string Brand,int Temperature)
    //{
    //    public string? Brand { get; set; }
    //    public int Temperature { get; set; }
    //    string _brand = Brand;
    //    int _temperature = Temperature;
    //    public void StartCooling()
    //    {
    //        Console.WriteLine($"{_brand} refrigerator starts cooling.");
    //    }
    //    public void StopCooling() 
    //    {
    //        Console.WriteLine($"{_brand} refrigerator stops cooling.");
    //    }
        //public void PrintCoolingEnergy()
        //{
        //    Console.WriteLine($"{Brand} refrigerator uses {energyPerHour} kWh per day.");
        //}
    }

}

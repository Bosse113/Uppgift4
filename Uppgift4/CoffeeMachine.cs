using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Uppgift4
{
    internal class CoffeeMachine : Appliance, ISchedulable
    {
        private double energyPerHour;
        private int CupsPerBrew;
        public DateTime NextRun { get; set; }

        public CoffeeMachine(string brand, string room, double energyPerHour, int CupsPerBrew)
            : base(brand, room)
        {
            this.energyPerHour = energyPerHour;
            this.CupsPerBrew = CupsPerBrew;
        }

        public override string GetInfo()
        {
            return $"CoffeeMachine: {Brand} in {Room}";
        }

        public override void TurnOn()
        {
            base.TurnOn();
            //Console.WriteLine($"Coffeemachine {Brand} starts a brewing coffee.");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            //Console.WriteLine($"Coffeemachine ,{Brand}, is now off.");
        }

        public override double GetDailyEnergyUsage()
        {
            if (IsOn)
            {
                return energyPerHour ; 
            }

            return 0;
        }

        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"Coffemachine is scheduled for {NextRun}");
        }
        //internal class CoffeeMachine(string Brand,int CupsPerBrew)
        //{
        //    public string? Brand { get; set; }
        //    public int CupsPerBrew { get; set; }

        //    string _brand = Brand;
        //    int _cupsPerBrew = CupsPerBrew;

        //    public void StartBrewing()
        //    {
        //        Console.WriteLine($"{_brand} brewer starts brewing.");
        //    }
        //    public void StopBrewing()
        //    {
        //        Console.WriteLine($"{_brand} brewer stops brewing.");
        //    }
        //public void PrintBrewingEnergy()
        //{
        //    Console.WriteLine($"{Brand} brewer uses {energyPerHour} kWh per brew.");
        //}

    }
    }

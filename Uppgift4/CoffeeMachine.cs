using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Uppgift4
{
    internal class CoffeeMachine : Appliance
    {
        private double energyPerHour;
        private int CupsPerBrew;

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
            Console.WriteLine($"{Brand} coffeemachine starts a brewing coffee.");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine($"Coffeemachine ,{Brand}, has finished and is now off.");
        }

        public override double GetDailyEnergyUsage()
        {
            if (IsOn)
            {
                return energyPerHour ; 
            }

            return 0;
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
        public void PrintBrewingEnergy()
        {
            Console.WriteLine($"{Brand} brewer uses 0.3 kWh per brew.");
        }

        }
    }

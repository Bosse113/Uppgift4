using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class Washer : Appliance, ISchedulable
    {
        private double energyPerHour;
        private int CapacityKg;
        public DateTime NextRun { get; set; }

        public Washer(string brand, string room, double energyPerHour,int CapacityKg)
            : base(brand, room)
        {
            this.energyPerHour = energyPerHour;
            this.CapacityKg = CapacityKg;
        }

        public override string GetInfo()
        {
            return $"Washing machine: {Brand} in {Room}";
        }

        public void TurnOn()
        {
            base.TurnOn();
            //Console.WriteLine($"Washer {Brand} starts a washing program.");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            //Console.WriteLine($"Washing machine ,{Brand}, is now off.");
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
            Console.WriteLine($"Washer {Brand} is scheduled for {NextRun}");
        }
        //internal class Washer(string Brand,int CapacityKg)
        //{
        //    public string? Brand { get; set; }
        //    public int CapacityKg { get; set; }
        //    string _brand=Brand;
        //    int _capacityKg=CapacityKg;

        //    public void StartWash()
        //    {
        //        Console.WriteLine($"{_brand} washer starts washing.");
        //    }
        //    public void StopWash() 
        //    { 
        //        Console.WriteLine($"{_brand} washer stops washing.");
        //    }
        //public void PrintWashEnergy()
        //{
        //    Console.WriteLine($"{Brand} washer uses {energyPerHour} kWh per wash.");
        //}
    }
}

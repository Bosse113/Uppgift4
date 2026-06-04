using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class GamingConsole:Appliance
    {

        private double energyPerHour;
        private int NumberOfGames;

        public GamingConsole(string brand, string room, double energyPerHour, int NumberOfGames)
            : base(brand, room)
        {
            this.energyPerHour = energyPerHour;
            this.NumberOfGames = NumberOfGames;
        }
        //ToDo : ändra till typ istf text OBS på alla i Appliance
        public override string GetInfo()
        {
            return $"Gaming console: {Brand} in {Room}";
        }

        public override void TurnOn()
        {
            base.TurnOn();
            //Console.WriteLine($"Gaming console {Brand} starts a washing program.");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            //Console.WriteLine($"Gaming console ,{Brand}, is now off.");
        }

        public override double GetDailyEnergyUsage()
        {
            if (IsOn)
            {
                return energyPerHour;
            }

            return 0;
        }
    }
}

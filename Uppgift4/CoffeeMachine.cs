using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Uppgift4
{
    internal class CoffeeMachine(string Brand,int CupsPerBrew)
    {
        public string? Brand { get; set; }
        public int CupsPerBrew { get; set; }

        string _brand = Brand;
        int _cupsPerBrew = CupsPerBrew;

        public void StartBrewing()
        {
            Console.WriteLine($"{_brand} brewer starts brewing.");
        }
        public void StopBrewing()
        {
            Console.WriteLine($"{_brand} brewer stops brewing.");
        }
        public void PrintBrewingEnergy()
        {
            Console.WriteLine($"{_brand} brewer uses 0.3 kWh per brew.");
        }

    }
}

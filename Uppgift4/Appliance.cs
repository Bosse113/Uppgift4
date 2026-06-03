using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class Appliance
    {
//Du ska själv fylla i basklassen.När du är klar ska den:
//ha en fungerande konstruktor
//kunna spara Brand
//kunna spara Room
//kunna hålla koll på IsOn
//ha metoder som kan override:as i child classes
        public string? Brand { get; }
        public string? Room { get; }
        public bool IsOn { get; protected set; }
        public Appliance(string brand, string room)
        {
            Brand = brand;
            Room = room;
            IsOn = false;
        }
        public virtual string GetInfo() 
        {
            //
            // Returnera en generell text om apparaten. 
            // Exempel: "LG in Laundry room"
            return $"{Brand} in {Room} room.";
           
        }
            public virtual void TurnOn() 
        {
            // 
            // Sätt IsOn till true. 
            // Skriv ut ett generellt startmeddelande.
            IsOn = true;
            Console.WriteLine($"{Brand} is now turned on.");
           
        } 
        public virtual void TurnOff() {
            // 
            // Sätt IsOn till false. 
            // Skriv ut ett generellt stoppmeddelande.
            IsOn = false;
            Console.WriteLine($"{Brand} is now turned off.");
            
        } 
        public virtual double GetDailyEnergyUsage() {
            // 
            // Returnera 0 som standardvärde.
            return 0;
           
            //
            //
        }
        }
}

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
        public string Brand { get; }
        public string Room { get; }
        public bool IsOn { get; protected set; }
        public Appliance(string brand, string room)
        { // TODO: 
            // Sätt Brand, Room och IsOn.
        }
          public virtual string GetInfo() 
        { 
            // TODO: 
            // Returnera en generell text om apparaten. 
            // Exempel: "LG in Laundry room"
            throw new NotImplementedException(); 
        }
            public virtual void TurnOn() 
        { 
            // TODO: 
            // Sätt IsOn till true. 
            // Skriv ut ett generellt startmeddelande.
            throw new NotImplementedException(); 
        } 
        public virtual void TurnOff() { 
            // TODO: // Sätt IsOn till false. 
            // Skriv ut ett generellt stoppmeddelande.
            throw new NotImplementedException(); } 
        public virtual double GetDailyEnergyUsage() { 
            // TODO: 
            // Returnera 0 som standardvärde.
            throw new NotImplementedException();
            //
            //
        }
        }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class PizzaOven : Oven
    {
    
    public PizzaOven(string brand, string room, int maxTemperature)
            : base(brand, room, maxTemperature) { }
        public override void TurnOn() { Console.WriteLine("Pizza oven starts at extra high temperature."); }
        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}
// ************** Frågor Del 12 ************

//1. Vad säger kompilatorn?
//   Vi får error CS0239 . Den säger att vi inte kan overrida Oven.TurnOn() för att den är sealed.
//2.Varför får PizzaOven inte override:a TurnOn()?
//   Oven:TurnOn() är sealed och eftersom Oven overridar TurnOn från Appliance så kan den inte overridas från Oven.
//3.När kan det vara rimligt att använda sealed override?
//     När man vill säkerställa att ingen annan class använder den specifika metoden. 
//4.Vad kan PizzaOven fortfarande göra i stället? Kan den override:a någon annan metod?
//   Använda en egen metod för TurnOn(), Ja  exempelvis GetInfo() går bra att overridea.



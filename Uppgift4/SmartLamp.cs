using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class SmartLamp:Appliance
    {
        public int Brightness { get; set; }
        public SmartLamp(string brand, string room, int brightness)
            : base(brand, room)
        { // TODO: 
          // Spara brightness.
            this.Brightness = brightness;
        }
        public override void TurnOn()
        { // TODO: 
          // Skriv ut att lampan tänds. 
            Console.WriteLine("SmartLamp is lit.");
        }
    }
    // Fråga 11****
    //1. Blir utskriften samma?
    //      Nej med New får jag :    SmartLamp is lit. IKEA is now turned on.
    //      och med override: SmartLamp is lit.SmartLamp is lit.
    //2. Vilken metod körs när variabeln har typen SmartLamp?
    //        SmartLamp.TurnOn().
    //3. Vilken metod körs när variabeln har typen Appliance?
    //       Appliance.TurnOn().
    //4. Varför är detta farligt eller förvirrande?
    //      Vi kan ju få olika resultat om vi inte har koll på vilken metod som används
    //5. Vad händer om du byter new till override?
    //      Då ersätter ju SmartLamp.TurnOn() bas metoden.
    //Skriv en kommentar som förklarar detta med dina egna ord:
    //      New döljer basmetoden medan override ersätter den.
    //      Med New så avgör variabelns typ (SmartLamp eller Appliance) vilken metod som körs.
    //      Men override så körs alltid metoten i SmartLamp oberoende av variabelns typ.

}

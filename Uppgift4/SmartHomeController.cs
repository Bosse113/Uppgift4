using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    internal class SmartHomeController
    {
        private List<Appliance> _devices = new List<Appliance>();
        public void AddDevice(Appliance device)
        { // TODO: 
          // Lägg till device i listan.
            _devices.Add(device);
        }
        public void TurnOnAll()
        { // TODO: // Loopa igenom alla devices och starta dem. 
          // Du får inte använda if/switch på specifika klasser.
            foreach (Appliance device in _devices)
            {
                device.TurnOn();
            }
        }
        public void TurnOffAll()
        { // TODO: 
          // Loopa igenom alla devices och stäng av dem.
            foreach (Appliance device in _devices)
            {
                device.TurnOff();
            }
        }
        public void PrintStatusReport()
        { // TODO: 
          // Loopa igenom alla devices. 
          // Skriv ut GetInfo() och om apparaten är på eller av.
            foreach (Appliance device in _devices)
            {
                Console.WriteLine(device.GetInfo());
            }
        }
        public double GetTotalDailyEnergyUsage()
        { // TODO: 
          // Räkna ihop GetDailyEnergyUsage() för alla devices. 
          // Returnera totalsumman.
            double totalDailyEnergyUsage = 0;
            foreach (Appliance device in _devices)
            {
                totalDailyEnergyUsage += device.GetDailyEnergyUsage();
            }
            return totalDailyEnergyUsage;
            throw new NotImplementedException();
        }
        public void ScheduleAllDevicesWrong(DateTime time)
        {
            //foreach (Appliance device in _devices)
            //{
            //    device.Schedule(time);
            //}
            // ******** Fråga **********
            // Varför kompilerar inte detta? Svara som kommentar.
        }   //Svar: Appliance har ingen koppling till metodet Schedule().

        public void ScheduleAllSchedulableDevices(DateTime time)
        {
            foreach (Appliance device in _devices)
            {
                // Kontrollera om device implementerar ISchedulable och casta schedulable till ISchedulabla
                if (device is ISchedulable schedulable)
                {
                    schedulable.Schedule(time);
                }
            }
        }
        //   ***************     Frågor efter Del 9 ************
        //1. Varför kan vi inte anropa Schedule() direkt på en variabel av typen Appliance?
        //      Schedule() finns inte i Appliance och hittas då inte.
        //2. Varför fungerar det efter att vi castar till ISchedulable?
        //      För då talar vi om för kompilatorn att objektet använder interfacet IScheduable.
        //3. Vad betyder det att RobotVacuum både är en Appliance och en ISchedulable?
        //      RobotVacuum ärver från Appliance och implementerar NextRun och Schedule() från ISchedulable.
        //4. Varför ska inte Schedule() ligga direkt i Appliance?
        //      Då alla apparater inte ska gå att schemalägga måste Schedule() finnas på dessa apparater som ska schemläggas.
        //5. Vad är skillnaden mellan arv och interface i det här exemplet?
        //      Arv beskriver vad objektet är och innehåller kod och metoder. 
        //      Interface kan beskrivas som ett kontrakt som måste implementeras i klassen eller koden.
    }
}

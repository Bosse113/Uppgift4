

using System.Reflection;

namespace Uppgift4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> devices = new List<object>(); 
            Washer washer = new Washer("Siemens", 10);
            devices.Add(washer);
            Refrigerator fridge = new Refrigerator("Elecrolux", 35);
            devices.Add(fridge);
            Oven oven = new Oven("Bosch", 200);
            devices.Add(oven);
            RobotVacuum robot = new RobotVacuum("Philips", 14);
            devices.Add(robot);

            // 
            // Skapa minst fyra objekt: 
            // Washer, Refrigerator, Oven och RobotVacuum. 
            // Lägg till dem i listan devices.
            RunMorningRoutine(devices);
            Console.WriteLine();
            ReportAllEnergy(devices);

            static void RunMorningRoutine(List<object> devices)
            {
                foreach (object device in devices)
                {
                    if (device is Washer washer)
                    { // 
                      // Casta device till Washer // Anropa Washer-metoder }
                        washer.StartWash();
                        washer.StopWash();
                    }
                    if (device is Refrigerator refrigerator)
                    { 
                       refrigerator.StartCooling();
                       refrigerator.StopCooling();
                    }
                    if (device is Oven oven)
                    { 
                        oven.StartHeating();
                        oven.StopHeating();
                    }
                    if (device is RobotVacuum robotVacuum)
                    { 
                        robotVacuum.StartCleaning();
                        robotVacuum.StopCleaning();
                    }
                    // 
                    // 1. Kontrollera vilken typ device är. 
                    // 2. Casta till rätt typ. 
                    // 3. Anropa rätt startmetod. 
                    // 4. Anropa rätt stoppmetod. }
                    //
                }
                

            }
            static void ReportAllEnergy(List<object> devices)
            {
                foreach (object device in devices)
                {
                    if (device is Washer washer)
                    { // 
                      // Casta device till Washer // Anropa Washer-metoder }
                        washer.PrintWashEnergy();
                        
                    }
                    if (device is Refrigerator refrigerator)
                    {
                        refrigerator.PrintCoolingEnergy();
                        
                    }
                    if (device is Oven oven)
                    {
                        oven.PrintHeatingEnergy();
                       
                    }
                    if (device is RobotVacuum robotVacuum)
                    {
                        robotVacuum.PrintCleaningEnergy();

                    }
                }
                // TODO: 
                // 1. Kontrollera vilken typ device är. 
                // 2. Casta till rätt typ. 
                // 3. Anropa rätt energimetod. }
                //1.Varför behövde du kontrollera vilken typ varje objekt hade?
                //    För att veta vilken metod som ska anropas
                //2.Vad händer om du lägger till en ny klass CoffeeMachine ?
                //   Då måste jag skapa nya metoder och nya IF-satser.
                //3.Vilka metoder måste du ändra om du lägger till CoffeeMachine?
                //   Start/Stop,RunMorningRoutine och ReportAllEnergy
                //4.Vad är problemet med att listan är List<object> ?
                //   Programmet vet inte om object är Oven,RobotVacuum m.m.
                //5.Vad händer om du råkar glömma en apparattyp i ReportAllEnergy()?
                //   DÅ får vi ingen rapport på den apparattypen.
            }
        }
    }
}

using Exercise_4;

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
                    if (device is Washer)
                    { // TODO: // Casta device till Washer // Anropa Washer-metoder }

                    }
                    if (device is Refrigerator)
                    { // TODO: 

                    }
                    if (device is Oven)
                    { // TODO: 

                    }
                    if (device is RobotVacuum)
                    { // TODO: 

                    }
                    // TODO: 
                    // 1. Kontrollera vilken typ device är. 
                    // 2. Casta till rätt typ. 
                    // 3. Anropa rätt startmetod. 
                    // 4. Anropa rätt stoppmetod. }
                    //
                }
                static void ReportAllEnergy(List<object> devices)
                {
                    foreach (object device in devices)
                    {

                    }
                    // TODO: 
                    // 1. Kontrollera vilken typ device är. 
                    // 2. Casta till rätt typ. 
                    // 3. Anropa rätt energimetod. }
                }

            }
        }
    }
}

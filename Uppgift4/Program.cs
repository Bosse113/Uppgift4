

using System.Reflection;

namespace Uppgift4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Flyttad till SmartHomeController
            //List<Appliance> devices = new List<Appliance>();
            //List<object> devices = new List<object>(); 
            //Washer washer = new Washer("Siemens","kitchen,",1.2, 10);
            //devices.Add(washer);
            //Refrigerator refrigerator = new Refrigerator("Elecrolux","kitchen",3.6, 35);
            //devices.Add(refrigerator);
            //Oven oven = new Oven("Bosch","kitchen",2.5 , 200);
            //devices.Add(oven);
            //RobotVacuum robot = new RobotVacuum("Philips","livingroom" , 0.4, 14);
            //devices.Add(robot);
            //CoffeeMachine coffeeMachine = new CoffeeMachine("MoccaMaster","kitchen" ,0.3,10);
            //devices.Add(coffeeMachine);

            SmartHomeController controller = new SmartHomeController();
            // TODO: 
            // Lägg till minst fem olika apparater.
            Washer washer = new Washer("Siemens", "kitchen,", 1.2, 10);
            controller.AddDevice(washer);
            Refrigerator refrigerator = new Refrigerator("Elecrolux", "kitchen", 3.6, 35);
            controller.AddDevice(refrigerator);
            Oven oven = new Oven("Bosch", "kitchen", 2.5, 200);
            controller.AddDevice(oven);
            RobotVacuum robot = new RobotVacuum("Philips", "livingroom", 0.4, 14);
            controller.AddDevice(robot);
            CoffeeMachine coffeeMachine = new CoffeeMachine("MoccaMaster", "kitchen", 0.3, 10);
            controller.AddDevice(coffeeMachine);
            GamingConsole gamingConsole = new GamingConsole("XBOX", "Living room", 0.5, 8);
            controller.AddDevice(gamingConsole);
          
            controller.PrintStatusReport();
            Console.WriteLine();
            controller.TurnOnAll();
            Console.WriteLine(); 
            double totalEnergy = controller.GetTotalDailyEnergyUsage();
            Console.WriteLine($"Total daily energy usage: {totalEnergy} kWh");
            Console.WriteLine();
            controller.TurnOffAll();

            // 
            // Skapa minst fyra objekt: 
            // Washer, Refrigerator, Oven och RobotVacuum. 
            // Lägg till dem i listan devices.

            //Del 5
            //RunMorningRoutine(devices);
            //Console.WriteLine();
            //ReportAllEnergy(devices);

            //static void RunMorningRoutine(List<Appliance> devices)
            //{
            //    foreach (Appliance device in devices)
            //    {
            //        string Info=device.GetInfo();
            //        Console.WriteLine(Info);
            //        device.TurnOn();
            //        double Info2 = device.GetDailyEnergyUsage();
            //        Console.WriteLine($"Energy usage is {Info2}");
            //        device.TurnOff();
            //    }
                //foreach (Appliance device in devices)
                //{
                //    if (device is Washer washer)
                //    { // 
                //      // Casta device till Washer // Anropa Washer-metoder }
                //        washer.TurnOn();
                //        washer.TurnOff();
                //    }
                //    if (device is Refrigerator refrigerator)
                //    { 
                //       refrigerator.TurnOn();
                //       refrigerator.TurnOff();
                //    }
                //    if (device is Oven oven)
                //    { 
                //        oven.TurnOn();
                //        oven.TurnOff();
                //    }
                //    if (device is RobotVacuum robotVacuum)
                //    { 
                //        robotVacuum.TurnOn();
                //        robotVacuum.TurnOff();
                //    }
                //    if (device is CoffeeMachine coffeeMachine)
                //    {
                //        coffeeMachine.TurnOn();
                //        coffeeMachine.TurnOff();
                //    }
                //    // 
                //    // 1. Kontrollera vilken typ device är. 
                //    // 2. Casta till rätt typ. 
                //    // 3. Anropa rätt startmetod. 
                //    // 4. Anropa rätt stoppmetod. }
                //    //
                //
              


        }
            //static void ReportAllEnergy(List<Appliance> devices)
            //{
            //    foreach (object device in devices)
            //    {
            //        if (device is Washer washer)
            //        { // 
            //          // Casta device till Washer // Anropa Washer-metoder }
            //            washer.PrintWashEnergy();
                        
            //        }
            //        if (device is Refrigerator refrigerator)
            //        {
            //            refrigerator.PrintCoolingEnergy();
                        
            //        }
            //        if (device is Oven oven)
            //        {
            //            oven.PrintHeatingEnergy();
                       
            //        }
            //        if (device is RobotVacuum robotVacuum)
            //        {
            //            robotVacuum.PrintCleaningEnergy();

            //        }
            //        if (device is CoffeeMachine coffeeMachine)
            //        {
            //           coffeeMachine.PrintBrewingEnergy();

            //        }
            //    }
                // TODO: 
                // 1. Kontrollera vilken typ device är. 
                // 2. Casta till rätt typ. 
                // 3. Anropa rätt energimetod.
                // 
                //*************Frågor*****************

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

                // När jag lade till CoffeeMachine behövde jag ändra på 3 ställen plus den nya klassen

                //******Frågor efter del 5:
                //      1. Varför fungerar device.TurnOn() trots att device har typen Appliance?
                //          De olika classerna ärver Appliance och overidar TurnOn.
                //      2. Vilken metod körs om objektet egentligen är en RobotVacuum?
                //          RobotVacuum.TurnOn()
                //      3. Vad blev bättre jämfört med List<object>?
                //          Vi vet typen som läggs in i listan, så säkerheten ökade.
            
    }
    
}

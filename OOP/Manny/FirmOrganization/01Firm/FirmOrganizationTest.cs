using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01Firm;
namespace FirmOrganization
{
    class FirmOrganizationTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================MACNINE======================================");
            Machine firstRvdMachine = new Machine("Horizontal_RVD", "RVD_DPC", "23143LKDP");
            firstRvdMachine.PrintInfo();
            Machine firstErosionMachine = new Machine("Erosion_300ET", "Erosion", "54658LKDP");
            Machine firstComputerMachine = new Machine("Pravec_16", "Computer", "54645LKDP");

            Machine secondRvdMachine = new Machine("Vertical_RVD", "RVD_DPC", "23343LKDP");
            Machine secondErosionMachine = new Machine("Erosion_200ET", "Erosion", "54658LKDP");
            Machine secondComputerMachine = new Machine("Pravec_32", "Computer", "11645LKDP");

            Machine thirdRvdMachine = new Machine("TwoHeads_RVD", "RVD_DPC", "24443LKDP");
            Machine thirdErosionMachine = new Machine("Erosion_100ET", "Erosion", "54448LKDP");
            Machine thirdComputerMachine = new Machine("Samsung", "Computer", "43445LKDP");
            Console.WriteLine();
            Console.WriteLine("===============================LIST<MACHINES>===================================");

            List<Machine> RVDMachines= new List<Machine>();
            RVDMachines.Add(firstRvdMachine);
            RVDMachines.Add(secondRvdMachine);
            RVDMachines.Add(thirdRvdMachine);
            Console.WriteLine("ALL RVD MACHINES");
            Console.WriteLine(RVDMachines[0].Name);
            Console.WriteLine(RVDMachines[1].Name);
            Console.WriteLine(RVDMachines[2].Name);

            List<Machine> ErosionMachines= new List<Machine>();
            ErosionMachines.Add(firstErosionMachine);
            ErosionMachines.Add(secondErosionMachine);
            ErosionMachines.Add(thirdErosionMachine);

            List<Machine> allFirmMachines = new List<Machine>();
            allFirmMachines.Add(firstRvdMachine);
            allFirmMachines.Add(secondRvdMachine);
            allFirmMachines.Add(thirdRvdMachine);
            allFirmMachines.Add(firstErosionMachine);
            allFirmMachines.Add(secondErosionMachine);
            allFirmMachines.Add(thirdErosionMachine);

            List<Machine> computerMachines= new List<Machine>();
            computerMachines.Add(firstComputerMachine);
            computerMachines.Add(secondComputerMachine);
            computerMachines.Add(thirdComputerMachine);
            Console.WriteLine();

            Console.WriteLine("=====================TOOL=======================================================");
            Tool firstBrekableTool = new Tool("litleBreakTool", "Breakable", "53455LKDP");
            firstBrekableTool.PrintInfo();
            Tool firstDimensionableTool = new Tool("HightPreciseTool", "Dimensionable", "33455LKDP");

            Tool secondBrekableTool = new Tool("BigBreakTool", "Breakable", "533335LKDP");
            Tool secondDimensionableTool = new Tool("LowPreciseTool", "Dimensionable", "33335LKDP");
            Console.WriteLine();

            Console.WriteLine("================================LIST<TOOLS>=====================================");
            List<Tool> breakableTools = new List<Tool>();
            breakableTools.Add(firstBrekableTool);
            breakableTools.Add(secondBrekableTool);
            Console.WriteLine("ALL BREAKABLE TOOLS");
            Console.WriteLine(breakableTools[0].Name);
            Console.WriteLine(breakableTools[1].Name);

            List<Tool> dimensionableTools = new List<Tool>();
            dimensionableTools.Add(firstDimensionableTool);
            dimensionableTools.Add(secondDimensionableTool);
            Console.WriteLine();

            Console.WriteLine("===============================WORKER===========================================");
            Worker firstRVDWorker = new Worker("Ivan Ivanov", "Trakiq 71", 'm',"6611224455", "82-33-22", 4, 200, "Technical"
                , "RVD_DCP", 3.0);
            firstRVDWorker.PrintInfo();
            Console.WriteLine("This worker Gain for the mounth is:"+firstRVDWorker.GainCalculating());
            Worker firstErosionWorker = new Worker("Petkan Ivanov", "Trakiq 41", 'm', "6601224485", "82-63-92", 8, 200
                , "Technical", "Erosion", 2.0);
            Worker firstComputerWorker = new Worker("Jordan Jordanov", "Trakiq 91", 'm', "6701225495", "82-69-96", 9, 200
                , "IT", "Computer", 4.0);

            Worker secondRVDWorker = new Worker("Dimitar Petrov", "Trakiq 101", 'm', "6912624485", "82-73-22", 7, 190, "Technical"
                , "RVD_DCP", 3.0);
            Worker secondErosionWorker = new Worker("Dimitar Dimitrov", "Trakiq 51", 'm', "8601020485", "82-93-32", 2, 200
                , "Technical", "Erosion", 2.0);
            Worker secondComputerWorker = new Worker("Simo Somovov", "Trakiq 11", 'm', "6901125995", "82-99-66", 9, 200
                , "IT", "Computer", 4.0);
            Console.WriteLine();

             Worker monitorRVDWorker = new Worker("Kolio Burov", "Trakiq 201", 'm', "5911124785", "82-13-92", 13, 230
                 , "Technical", "RVD_CDP", 5.0);
            Worker monitorErosionWorker = new Worker("Kiril Kotev", "Trakiq 86", 'm', "6601120795", "82-13-92", 11, 230
                , "Technical", "Erosion", 5.0);
            Worker monitorComputerWorker = new Worker("Lilian Somov", "Trakiq 19", 'm', "6201005095", "82-19-16", 17, 230
                , "IT", "Computer", 4.0);
            Console.WriteLine();

            Console.WriteLine("========================LIST<worker>============================================");
            List<Worker> technicalSectionWorkers = new List<Worker>();
            technicalSectionWorkers.Add(firstRVDWorker);
            technicalSectionWorkers.Add(secondRVDWorker);
            technicalSectionWorkers.Add(monitorRVDWorker);
            technicalSectionWorkers.Add(firstErosionWorker);
            technicalSectionWorkers.Add(secondErosionWorker);
            technicalSectionWorkers.Add(monitorErosionWorker);
            technicalSectionWorkers.Add(firstComputerWorker);
            technicalSectionWorkers.Add(secondComputerWorker);
            technicalSectionWorkers.Add(monitorComputerWorker);

            List<Worker> ITSectionWorkers = new List<Worker>();
            ITSectionWorkers.Add(firstComputerWorker);
            ITSectionWorkers.Add(secondComputerWorker);
            ITSectionWorkers.Add(monitorComputerWorker);
            Console.WriteLine("ALL IT SECTION WORKERS");
            Console.WriteLine(ITSectionWorkers[0].Name);
            Console.WriteLine(ITSectionWorkers[1].Name);
            Console.WriteLine(ITSectionWorkers[2].Name);


            List<Worker> allWorkers = new List<Worker>();
            allWorkers.Add(firstRVDWorker);
            allWorkers.Add(secondRVDWorker);
            allWorkers.Add(monitorRVDWorker);
            allWorkers.Add(firstErosionWorker);
            allWorkers.Add(secondErosionWorker);
            allWorkers.Add(monitorErosionWorker);
            allWorkers.Add(firstComputerWorker);
            allWorkers.Add(secondComputerWorker);
            allWorkers.Add(monitorComputerWorker);

            Console.WriteLine("=================================PRODUCTS=======================================");
            Product firstProduct = new Product("Big Form for Casket", 1000, 200, 20000, Matirial.iron);
            firstProduct.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("The Gain from firstProduct= " + firstProduct.CalculatingProductGain());
            Product secondProduct = new Product("Normal Form for Casket", 800, 180, 17000, Matirial.iron);
            Product thirdProduct = new Product("Little Form for Casket", 600, 150, 13000, Matirial.pigIron);
            Console.WriteLine();

            Console.WriteLine("=================================STORES=========================================");
            Store firstStore = new Store("For Products", firstErosionWorker);
            firstStore.PrintInfo();
            Store secondStore = new Store("For Dimensionable Tools ", firstErosionWorker);
            Store thirdStore = new Store("For Brekable Tools", firstRVDWorker);
            Console.WriteLine();

            Console.WriteLine("==============================MACHINE TYPE======================================");
            MachinesType firstMachineType = new MachinesType("RVD_DCP", monitorRVDWorker, RVDMachines);
            firstMachineType.PrintInfo();
            MachinesType secondMachineType = new MachinesType("Erosion",monitorErosionWorker, ErosionMachines);
            MachinesType thirdMachineType = new MachinesType("Computer", monitorComputerWorker, computerMachines);
            Console.WriteLine();

            Console.WriteLine("==============================TOOLS TYPE========================================");
            ToolsType firstToolsType = new ToolsType("Breakable Tools Type", breakableTools);
            firstToolsType.PrintInfo();
            ToolsType secondToolsType = new ToolsType("Dimensionable Tools Type", dimensionableTools);
            secondToolsType.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("===============================SECTIONS=========================================");
            Section firstSection = new Section("Technical", technicalSectionWorkers, monitorRVDWorker);
            firstSection.PrintInfo();
            Console.WriteLine();

            

            Console.WriteLine("==============================FIRM==============================================");
            Worker theOwner = new Worker("Todor Kolev","Trakiq 342",'m',"6603225578","82-77-88",22,250,null,null,10.0);
            MachinalEngineeringFirm someFirm=new MachinalEngineeringFirm("Lidia Dako Plast","Trakiq 432"
                ,"Forms for Plastic products",theOwner,allWorkers,allFirmMachines,new GiveTakeForMounthDeclare(4000,40000));
            someFirm.PrintInfo();

            Console.WriteLine();
            Console.WriteLine("====================GIVE TAKE MONEY FROM THE FIRM FOR THE MOUNTH================");
            someFirm.TheDeclaration = new GiveTakeForMounthDeclare(5000, 50000);
            Console.WriteLine(someFirm.TheDeclaration);
            Console.WriteLine();
            
            Console.WriteLine("=====================EVENT TEST=================================================");
            BossMood bossMoodToday = new BossMood(5);

            bossMoodToday.Normal += (sender, eventInfo) =>
            {
                Console.WriteLine("Congratulations we made a good job tomorow will have ADVANCE money");
            };

            bossMoodToday.Advance += (sender, eventInfo) =>
            {
                Console.WriteLine("Congratulations we made a good job tomorow will have ADVANCE money");
            };

            bossMoodToday.SaturdayWork += (sender, eventInfo) =>
            {
                Console.WriteLine("We work slow so this SATURDAY we will work");
            };

            Console.WriteLine("=================CHECK INVALID RANGE EXCEPTION CLASS============================");
            InvalidRangeException<int> intExeption =
               
               
                new InvalidRangeException<int>("The range is not valid must be between[3, 50]!", 3, 50);
            
            
            
            
            someFirm.Owner.Name = "sdfadafaffgdfghdfhhhh";
            if (someFirm.Owner.Name.Length < intExeption.Start || someFirm.Owner.Name.Length > intExeption.End)
            {
                throw intExeption;
            }
            else
            {
                Console.WriteLine(someFirm.Owner.Name);
            }




            //IImportantMassegable keyboard = new KeyBoard();
            //keyboard.Advance += (sender, eventInfo) =>
            //{
            //    Console.WriteLine("Congratulations we made a good job tomorow will have ADVANCE money"); 
            //};

            //keyboard.SaturdayWork += (sender, eventInfo) =>
            //{
            //    Console.WriteLine("We work slow so this SATURDAY we will work");
            //};

        }
    }
}

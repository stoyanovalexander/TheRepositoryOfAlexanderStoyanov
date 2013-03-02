using DefiningClassesPartOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class InfoAboutMobilePhone
    {
        static void Main(string[] args)
        {
            // Task7: TestGSM
            Console.WriteLine("Task7: TestGSM");
            Display[] displays = new Display[]
            {
                new Display(6),
                new Display(5,16),
                new Display(4)
            };
            Battery[] batteries = new Battery[]
            {
                new Battery("Asenova"),
                new Battery("Ivanova",43),
                new Battery("Popova",33,44,BatteryType.Lilon),
            };
            GSM[] gsms = new GSM[]
            {
                new GSM(),
                new GSM("Nokia","Japan","Huren",batteries[0],displays[0]),
                new GSM("Newest","Modern","Stoqn",batteries[1],displays[1]),
                new GSM("Samsung","Bulgaria","Semra", batteries[2],displays[2])
            };
            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm);
                Console.WriteLine();
            }
            Console.WriteLine(GSM.Iphone4S);

            // Task12: GsmCallHistoryTest
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Task12: GsmCallHistoryTest");
      
            
          
            Battery gsmTwoBattery = new Battery("Toshiba", 123, 456, BatteryType.Lilon);
            Display gsmTwoDisp = new Display(33, 44);
            GSM gsmTwo = new GSM("BigWork", "MasterOne", "Huren", gsmTwoBattery, gsmTwoDisp);
            Console.WriteLine(gsmTwo);

            Battery gsmThreeBattery = new Battery("Tokio", 34244);
            Display gsmThreeDisplay = new Display(1324);
            GSM gsmThree = new GSM("Bash", "BashMaster", 5, "Hasan", gsmThreeBattery, gsmThreeDisplay,null);
            Console.WriteLine(gsmThree);
            

            List<Call> gsmOneCallHistory=new List<Call>();
            Call firstCallGsmOne=new Call("68-86-87",435);
            Call secondCallGsmOne=new Call("82-25-50",120);
            Call thirdCallGsmOne=new Call("82-68-77",66);
            
            gsmOneCallHistory.Add(firstCallGsmOne);
            gsmOneCallHistory.Add(secondCallGsmOne);
            gsmOneCallHistory.Add(thirdCallGsmOne);
            
            Console.WriteLine();
            GSM gsmOne=new GSM(gsmOneCallHistory);
            Call forAdd = new Call("11/77/77", 32333);
            gsmOne.AddCall(forAdd);  

            foreach (var call in gsmOneCallHistory)
            {
                Console.WriteLine(call);
            }

            Console.WriteLine( gsmOne.MakeSum(0.37));

            int k = -2;
            int maxDuration = -2;
            for (int i = 0; i < gsmOneCallHistory.Count; i++)
            {
                if (gsmOneCallHistory[i].Duration > maxDuration)
                {
                    maxDuration = gsmOneCallHistory[i].Duration;
                    k = i;
                }
            }
            gsmOne.DelCall(k);
            Console.WriteLine(gsmOne.MakeSum(0.37));

            gsmOne.Clear();
            foreach (var call in gsmOneCallHistory)
            {
                Console.WriteLine(call);
            }
        }
    }
    


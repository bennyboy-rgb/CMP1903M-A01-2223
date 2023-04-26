using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
            dynamic tutor = new MainMenu();
            tutor.menu();

            //threelevel threelevel = new threelevel();
            //threelevel.OutputEquation();
            //threelevel.userInput();



            /*Help.firstmessage();
            Help.operators();
            Help.sample();
            
            WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Log is Created at", DateTime.Now));
            //Console.WriteLine("Log is Written Successfully !!!");
           
            Questions.shufflegameMethod();
            Questions.playAgain();*/
            Console.ReadLine();
          
        }
    }
}

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
            Messages messages = new Messages();
            Console.WriteLine(messages.welcomemessage());

            dynamic tutorial = new MainMenu();
            tutorial.menu();


            WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Log is Created at", DateTime.Now));
            Console.WriteLine("\n\nLog is Written Successfully !!!");
            Console.ReadLine();
          
        }
    }
}

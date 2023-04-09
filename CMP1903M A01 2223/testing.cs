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
            //welcomeMessage.firstmessage();
            //welcomeMessage.operators();
            //welcomeMessage.sample();

            WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Log is Created at", DateTime.Now));
            Console.WriteLine("Log is Written Successfully !!!");
            //Questions.first_question();
            //Questions.second_question();
            //Questions.ThirdQUestion();
            //Questions.shufflegameMethod();
            //Questions.playAgain();
            Console.ReadLine();
          
        }
    }
}

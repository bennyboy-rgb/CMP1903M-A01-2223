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
            //MainMenu.menu();

            List<Card> list = Pack.dealCard(3);
            foreach (Card card in list)
            {
                Console.WriteLine(card);
            }
           operation operate = new operation(list[0].Value, list[2].Value, list[1].Suit);
            double x = operate.performance();
            Console.WriteLine(x);



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

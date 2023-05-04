using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Redealcards
    {
        public static void otherSelector()
        {
            Messages messages = new Messages();// messages instantiated 
            threeCardslevel easy_level = new threeCardslevel();//threecards instantiated..
            fiveCardslevel HardLevel = new fiveCardslevel();

            bool valid = false;
            double UserInput = 0;
            while (!valid)
            {
                Console.WriteLine("\t(1) To Deal 3 Cards");
                Console.WriteLine("\t(2) To Deal 5 Cards");
                Console.WriteLine("\t(3) TO return to main Menu");
                if (double.TryParse(Console.ReadLine(), out UserInput))
                {
                    if (UserInput == 1)
                    {
                        valid = true;
                        Questions.shufflegameMethod();
                        Console.WriteLine(messages.CardDrawnMessages());
                        easy_level.Equation();
                        easy_level.userInput(easy_level.evaluate());
                        Questions playagain = new Questions();
                        playagain.playAgain();
                    }
                    else if (UserInput == 2)
                    {
                        valid = true;
                        Questions.shufflegameMethod();
                        Console.WriteLine(messages.CardDrawnMessages());
                        HardLevel.Equation();
                        HardLevel.userInput(HardLevel.evaluate());
                        Questions playagain = new Questions();
                        playagain.playAgain();
                    }
                    else if (UserInput == 3)
                    {
                        valid = true;
                        MainMenu menu = new MainMenu();
                        menu.menu();
                    }
                }
                else
                {
                    Console.WriteLine("Input an integer please !!");
                }
            }
        }

    }
}

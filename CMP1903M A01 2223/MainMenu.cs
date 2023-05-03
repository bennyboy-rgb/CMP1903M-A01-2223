using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class MainMenu
    {
        /// <summary>
        /// MAin menu, the control room of all operations
        /// </summary>
        public void menu()
        {
            
            Messages messages = new Messages();


            bool valid = false;
            int user_input = 0;
            while (!valid)
            {
                Console.WriteLine("\n\nINSTRUCTION!!!");
                Console.WriteLine("\tEnter :");
                Console.WriteLine("\t\t(1) To Deal 3 Cards");
                Console.WriteLine("\t\t(2) To Deal 5 Cards");
                Console.WriteLine("\t\t(3) For Help");
                Console.WriteLine("\t\t(4) To quit");

                if (int.TryParse(Console.ReadLine(), out user_input))
                {
                    if (user_input == 1)
                    {
                        valid = true;
                        Questions.shufflegameMethod();
                        Console.WriteLine(messages.CardDrawnMessages());
                        threeCardslevel easy_level = new threeCardslevel();
                        easy_level.Equation();
                        easy_level.userInput(easy_level.evaluate());
                        dynamic playerchoice = new Questions();

                        playerchoice.playAgain();

                    }
                    else if (user_input == 2)
                    {
                        valid = true;
                        Questions.shufflegameMethod();
                        Console.WriteLine(messages.CardDrawnMessages());
                       fiveCardslevel hardLevel = new fiveCardslevel();
                        hardLevel.Equation();
                        hardLevel.userInput(hardLevel.evaluate());
                        dynamic playerchoice = new Questions();

                        playerchoice.playAgain();

                    }
                    else if (user_input == 3)
                    {
                        valid = true;
                        Console.WriteLine(Help.firstmessage());
                        Help.operators();
                        Help.sample1();
                        Help.sample2();
                        Help.back();
                    }
                    else if (user_input == 4)
                    {
                        valid = true;
                        Console.WriteLine(messages.goodByeMessage()); 
                    }
                }
                else
                {
                    Console.WriteLine("input an integer please!!");
                }

            }

        }
        

      
    }
}

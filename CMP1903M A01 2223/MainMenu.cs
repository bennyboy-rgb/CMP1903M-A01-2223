using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class MainMenu
    {
        
        public void menu()
        {
            bool valid = false;
            int user_input = 0;
            while (!valid)
            {

                Console.WriteLine("Enter :");
                Console.WriteLine("(1) For easy level");
                Console.WriteLine("(2) For Hard level");
                Console.WriteLine("(3) For Help");
                Console.WriteLine("(4) To quit");

                if (int.TryParse(Console.ReadLine(), out user_input))
                {
                    if (user_input == 1)
                    {
                        valid = true;
                        Questions.shufflegameMethod();
                        dynamic threelevel= new threeCardslevel();
                        threelevel.OutputEquation();
                        threelevel.userInput();
                    }
                    else if (user_input == 2)
                    {
                        valid = true;
                     /*   int answer = fiveCardsLevel.playgame2();
                        if (answer == 1)
                        {
                            Console.WriteLine("Correct answer!!");
                        }
                        else
                        { Console.WriteLine($"Wrong Answer, The correct answer is {answer}"); }*/
                     dynamic hard_level= new fiveCardsLevel();
                        hard_level.evaluate();
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
                        Messages.goodByeMessage();
                    }
                }
                else
                {
                    Console.WriteLine("input an integer please!!");
                }

            }

            dynamic playerchoice = new Questions();
            playerchoice.playAgain();
        }
        

      
    }
}

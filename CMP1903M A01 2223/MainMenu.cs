using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class MainMenu
    {
        public static void menu()
        {
            bool valid = false;
            int user_input = 0;
            while (!valid)
            {

                Console.WriteLine("Enter :");
                Console.WriteLine("(1) for easy level");
                Console.WriteLine("(2) for Hard level");
                Console.WriteLine("(3) for Help");
                /*                Console.WriteLine(" Do you want to draw 3 cards or 5 cards \n Enter:\n(1) To Draw 3 cards\n(2) To draw 5 cards \n(3) To Quit");
                */
                if (int.TryParse(Console.ReadLine(), out user_input))
                {
                    if (user_input == 1)
                    {
                        valid = true;
                        int answer = threeCardsLevel.playgame();
                        if (answer == 1)
                        {
                            Console.WriteLine("correct answer !!");
                        }
                        else
                        {
                            Console.WriteLine($"wrong answer, the coorect answer is ({answer})");
                        }
                    }
                    else if (user_input == 2)
                    {
                        valid = true;
                        int answer = fiveCardsLevel.playgame2();
                        if (answer == 1)
                        {
                            Console.WriteLine("Correct answer!!");
                        }
                        else
                        { Console.WriteLine($"Wrong Answer, The correct answer is {answer}"); }
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
                }
                else
                {
                    Console.WriteLine("input an integer please!!");
                }

            }

        }

      
    }
}

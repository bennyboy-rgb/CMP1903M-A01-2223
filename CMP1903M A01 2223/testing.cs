//using System;
//using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Questions
    {
        public static void second_question()
        {
            int user_input = 0;
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("How many cards do you wan to deal : ");
                if (int.TryParse(Console.ReadLine(), out user_input))
                {
                    if (user_input <= 52)
                    {
                        valid = true;
                        foreach (Card card in Pack.dealCard(user_input))
                        {
                            Console.WriteLine(card);
                        }
                    }
                    else if (user_input <= 0 || user_input > 52)
                    {
                        Console.WriteLine("Invalid input please");
                    }
                }
            }
        }




        public static void first_question()
        {
            bool valid = false;
            int user_input = 0;

            while (!valid)
            {
                Console.WriteLine(" what shuffle method do you want do you want :\n ENTER \n (1) for fisheryate shuffling \n (2) for riffle shuffle \n (3) for no shuffle  ");
                if (int.TryParse(Console.ReadLine(), out user_input))
                {
                    if (user_input == 1 || user_input == 2 || user_input == 3)
                    {
                        valid = true;
                        Pack.shuffleCardPack(user_input);
                        Pack.parkprinter();
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid digit!");
                    }
                }
                else
                {
                    Console.WriteLine("please enter an integer!!");
                }

            }
        }
    }
}



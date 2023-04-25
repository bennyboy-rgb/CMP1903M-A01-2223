//using System;
//using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Questions
    {
        public static void card_dealer()
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




        public static void shuffler()
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
                       // Pack.parkprinter();
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

        public static void shufflegameMethod()
        {
           
            int user_input = 0;
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("Would you love to shuffle the cards before you begin?? \n Enter\n (1) for Yes \n (2) For NO");
                if (int.TryParse(Console.ReadLine(),out user_input))
                {
                    if ( user_input == 1)
                    {
                        valid = true;
                        Random random = new Random();
                        int index = random.Next(1, 3);
                        Pack.shuffleCardPack(index);
                    }
                    else  if (user_input == 2)
                    {
                        valid = true;
                        MainMenu.menu();
                    }
                    else
                    {
                        Console.WriteLine("Wrong input !!");
                    } 
                }
                else
                {
                    Console.WriteLine("please input an integer !!");
                }
            }
        }



        public static void playAgain()
        {
            bool valid = false;
            int user_input = 0;
             while (!valid)
             {
                Console.WriteLine("Would you love to try again : \n ENTER : \n (1) for Yes \n(2) to quit game ");
                if (int.TryParse(Console.ReadLine(), out user_input)) 
                {
                    if ( user_input == 1)
                    {
                        valid = true;
                        MainMenu.menu();
                    }
                    else if(user_input == 2)
                    {
                        valid = true;
                        Messages.goodByeMessage();
                    }
                    else
                    {
                        Console.WriteLine("input a valid input please");
                    }
                }
                else
                {
                    Console.WriteLine( "input an integer please!!");
                }
             }
        }
    }
    
}



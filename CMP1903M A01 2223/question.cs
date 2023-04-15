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
                        shuffler();
                        startGame();
                    }
                    else  if (user_input == 2)
                    {
                        valid = true;
                        startGame();
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

        public static void startGame()
        {
            bool valid = false;
            int user_input = 0; 
            while (!valid)
            {
                Console.WriteLine(" Do you want to draw 3 cards or 5 cards \n Enter:\n(1) To Draw 3 cards\n(2) To draw 5 cards \n(3) To Quit");
                if (int.TryParse(Console.ReadLine(),out user_input))
                {
                    if (user_input== 1)
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
                    else if(user_input == 3)
                    {
                        valid = true;
                        Console.WriteLine("Thank you for your time");
                    }
                }
                else
                {
                    Console.WriteLine("input an integer please!!");
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
                        startGame();
                    }
                    else if(user_input == 2)
                    {
                        valid = true;
                        Console.WriteLine("Thank you for your time!!");
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



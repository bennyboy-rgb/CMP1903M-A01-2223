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
                        first_question();
                        ThirdQUestion();
                    }
                    else  if (user_input == 2)
                    {
                        valid = true;
                        ThirdQUestion();
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

        public static void ThirdQUestion()
        {
            bool valid = false;
            int user_input = 0; 
            while (!valid)
            {
                Console.WriteLine("Are you ready to play this game : \n Input : \n(1) For Yes \n(2) For No");
                if (int.TryParse(Console.ReadLine(),out user_input))
                {
                    if (user_input== 1)
                    {
                        valid = true;

                        //Console.WriteLine(playgame());
                        if (playgame() == 1)
                        {
                            Console.WriteLine("correct answer !!");
                        }
                        else
                        {
                            Console.WriteLine($"wrong answer");
                        }
                    }
                    else
                    {
                        valid = true;
                        Console.WriteLine("Thank you for your time");
                    }
                }

            }

        }

        public static int playgame()
        {
            List<Card> newdeck = Pack.dealCard(3);
            Console.WriteLine("This are the cards drawn!!\n");
            foreach (Card card in newdeck)
            {
                Console.WriteLine(card);
            }
            if (newdeck[1].Suit == 1)
            {
                int user_answer = 0;
               bool valid = false;
                while (!valid)
                {
                    int question = newdeck[0].Value + newdeck[2].Value;
                    Console.WriteLine(newdeck[0].Value + "+" + newdeck[2].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                            valid = true;
                            return question;
                    }
                    else { Console.WriteLine("input an integer please"); }
                }
            }
            else if (newdeck[1].Suit == 2)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = newdeck[0].Value - newdeck[2].Value;
                    Console.WriteLine(newdeck[0].Value + "-" + newdeck[2].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                            valid = true;
                            return question;
                    }
                    else { Console.WriteLine("input an integer please"); }
                }

            }
            else if (newdeck[1].Suit == 3)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = newdeck[0].Value / newdeck[2].Value;
                    Console.WriteLine(newdeck[0].Value + "/" + newdeck[2].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                            valid = true;
                            return question;
                    }
                    else { Console.WriteLine("input an integer please"); }
                }


            }
            else if (newdeck[1].Suit == 4)
            {
                int user_answer = 0;
               bool valid = false;
                while (!valid)
                {
                    int question = newdeck[0].Value * newdeck[2].Value;
                    Console.WriteLine(newdeck[0].Value + "x" + newdeck[2].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                            valid = true;
                            return question;
                    }
                    else { Console.WriteLine("input an integer please"); }
                }

            }
            return -1;
            //foreach (Card card in newdeck)
            //{
            //    Console.WriteLine(card.Value);
            //}
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
                        ThirdQUestion();
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



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class fiveCardsLevel
    {
        public static int playgame2()
        {
            List<Card> cards = Pack.dealCard(5);
            Console.WriteLine("These are the cards drawn!!");
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
            if (cards[1].Suit == 1 && cards[3].Suit == 1)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value + cards[2].Value + cards[4].Value;
                    Console.WriteLine(cards[0].Value + "+" + cards[2].Value + "+" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine(" input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 1 && cards[3].Suit == 2)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value + cards[2].Value - cards[4].Value;
                    Console.WriteLine(cards[0].Value + "+" + cards[2].Value + "-" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else { Console.WriteLine("Input an integer please!!"); }
                }
            }
            else if (cards[1].Suit == 1 && cards[3].Suit == 3)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value + cards[2].Value * cards[4].Value;
                    Console.WriteLine(cards[0].Value + "+" + cards[2].Value + "x" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 1 && cards[3].Suit == 4)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value + cards[2].Value / cards[4].Value;
                    Console.WriteLine(cards[0].Value + "+" + cards[2].Value + "/" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an Integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 2 && cards[3].Suit == 1)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value - cards[2].Value + cards[4].Value;
                    Console.WriteLine(cards[0].Value + "-" + cards[2].Value + "+" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 2 && cards[3].Suit == 2)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value - cards[2].Value - cards[4].Value;
                    Console.WriteLine(cards[0].Value + "-" + cards[2].Value + "-" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 2 && cards[3].Suit == 3)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value - cards[2].Value / cards[4].Value;
                    Console.WriteLine(cards[0].Value + "-" + cards[2].Value + "/" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 2 && cards[3].Suit == 4)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value - cards[2].Value * cards[4].Value;
                    Console.WriteLine(cards[0].Value + "-" + cards[2].Value + "x" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 3 && cards[3].Suit == 1)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value / cards[2].Value + cards[4].Value;
                    Console.WriteLine(cards[0].Value + "/" + cards[2].Value + "+" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 3 && cards[3].Suit == 2)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value / cards[2].Value - cards[4].Value;
                    Console.WriteLine(cards[0].Value + "/" + cards[2].Value + "-" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 3 && cards[3].Suit == 3)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value / cards[2].Value / cards[4].Value;
                    Console.WriteLine(cards[0].Value + "/" + cards[2].Value + "/" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 3 && cards[3].Suit == 4)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value / cards[2].Value * cards[4].Value;
                    Console.WriteLine(cards[0].Value + "/" + cards[2].Value + "x" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 4 && cards[3].Suit == 1)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value * cards[2].Value + cards[4].Value;
                    Console.WriteLine(cards[0].Value + "x" + cards[2].Value + "+" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 4 && cards[3].Suit == 2)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value * cards[2].Value - cards[4].Value;
                    Console.WriteLine(cards[0].Value + "x" + cards[2].Value + "-" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 4 && cards[3].Suit == 3)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value * cards[2].Value / cards[4].Value;
                    Console.WriteLine(cards[0].Value + "x" + cards[2].Value + "/" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }
            else if (cards[1].Suit == 4 && cards[3].Suit ==4)
            {
                int user_answer = 0;
                bool valid = false;
                while (!valid)
                {
                    int question = cards[0].Value * cards[2].Value * cards[4].Value;
                    Console.WriteLine(cards[0].Value + "x" + cards[2].Value + "x" + cards[4].Value);
                    if (int.TryParse(Console.ReadLine(), out user_answer))
                    {
                        if (user_answer == question)
                        {
                            valid = true;
                            return 1;
                        }
                        else
                        {
                            valid = true;
                            return question;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input an integer please!!");
                    }
                }
            }


            return -1;
        }
    }
}

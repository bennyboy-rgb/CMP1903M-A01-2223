using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class threeCardsLevel
    {
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

        }

    }
}

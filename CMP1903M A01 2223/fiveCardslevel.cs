using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{

    class fiveCardslevel : parent
    {
        List<Card> cards = Pack.dealCard(5);
        public void Equation()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
        public double evaluate()
        {

            fiveCardoperation newoperator = new fiveCardoperation(cards[0].Value, cards[2].Value, cards[4].Value, cards[1].Suit, cards[3].Suit);
            Console.WriteLine(newoperator.ToString());
            bool valid = false;
            double answer = 0;
            if (cards[1].Suit >= cards[3].Suit)
            {

                operation operate = new operation(cards[0].Value, cards[2].Value, cards[1].Suit);
                Console.Write(operate.ToString());

                double y = operate.performance();
                userInput(y);
                while (!valid)
                {
                    double reply = 0;
                    Console.Write("Would you love to enter the answer again so you can move to the next question :");

                    if (double.TryParse(Console.ReadLine(), out reply))
                    {
                        valid = true;
                            operation operate2 = new operation(y, cards[4].Value, cards[3].Suit);
                            Console.Write(operate2.ToString());
                            answer = operate2.performance();
                    }
                    else
                    {
                        Console.WriteLine("input an integer please!!");
                    }
                }




            }
            else if (cards[1].Suit < cards[3].Suit)
            {
                operation operate2 = new operation(cards[2].Value, cards[4].Value, cards[3].Suit);
                Console.Write(operate2.ToString());

                double z = operate2.performance();
                userInput(z);/*
                Console.WriteLine("Would you love to enter the answer again so you can move to the next question :");

                double answer2;
                double.TryParse(Console.ReadLine(), out answer2);
                if (valid)
                {
                    operation operate = new operation(z, cards[0].Value, cards[1].Suit);
                    Console.Write(operate.ToString());
                    answer = operate.performance();
                }
                userInput(y);*/
                while (!valid)
                {
                    double reply = 0;
                    Console.Write("Would you love to enter the answer again so you can move to the next question :");

                    if (double.TryParse(Console.ReadLine(), out reply))
                    {

                        valid = true;
                        operation operate = new operation(z, cards[0].Value, cards[1].Suit);
                        Console.Write(operate.ToString());
                        answer = operate.performance();
                    }
                    else
                    {
                        Console.WriteLine("input an integer please!!");
                    }
                }




            }

            return answer;

        }

        public override void userInput(double question)
        {
            base.userInput(question);
        }
    }
}

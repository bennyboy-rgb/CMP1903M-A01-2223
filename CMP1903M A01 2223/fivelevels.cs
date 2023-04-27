using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{

    class fivelevels : threeCardslevel
    {
        List<Card> cards = Pack.dealCard(5);
        public override void Equation()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
        public override double evaluate()
        {
            dynamic operate = new operation(cards[0].Value, cards[2].Value, cards[4].Value, cards[1].Suit, cards[3].Suit);
            Console.WriteLine(operate.ToString());
            double x = operate.performance();
            return x;

        }
        public override void userInput()
        {
            bool valid = false;
            int counter = 0;
            float input = 0;
            while (!valid)
            {
                double answer = evaluate();
                if (float.TryParse(Console.ReadLine(), out input))
                {

                    if (input == answer)
                    {
                        valid = true;
                        Console.WriteLine("Yayy, correct answer!!");
                    }
                    else
                    {
                        /*valid = true;*/
                        Console.WriteLine("\nArghhh, wrong answer!!");

                        counter++;
                        if (counter < 2)
                        {
                            /*valid = true;*/
                            Console.Write("Try again : ");
                        }
                        else if (counter == 2)
                        {
                            valid = true;
                            Console.WriteLine($"The correct answer is {answer}\n");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Input an integer please!!");
                }

            }
        }
    }
}

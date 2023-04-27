using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class threeCardslevel
    {
    
        List<Card> cards = Pack.dealCard(3);

        public virtual void Equation()
        {
/*            List<Card> list = cards;
            foreach (Card card in cards)
            {
                list.Add(card);

            }*/
            /*return cards;*/
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
        public virtual double evaluate()
        {
            dynamic operate = new operation(cards[0].Value, cards[2].Value, cards[1].Suit);
            Console.WriteLine(operate.ToString());
            double x = operate.performance();

            return x;
            
        }

        public virtual void userInput()
        { 

            bool valid = false;
            int counter = 0;
            float  input = 0;
            while (!valid)
            {
                double answer= evaluate();
                if (float.TryParse(Console.ReadLine(),out input)){

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

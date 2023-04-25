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

        public void OutputEquation()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
        public virtual double evaluate()
        {
            operation operate = new operation(cards[0].Value, cards[2].Value, cards[1].Suit);
            Console.WriteLine(operate.ToString());
            double x = operate.performance();

            return x;
            
        }

        public void userInput()
        { 

            bool valid = false;
            int counter = 0;
            int  input = 0;
            while (!valid)
            {
                double answer= evaluate();
                if (int.TryParse(Console.ReadLine(),out input)){

                    if (input == answer)
                    {
                        valid = true;
                        Console.WriteLine("yayy, correct answer!!");
                    }
                    else
                    {
                        valid = true;
                        Console.WriteLine(" arghhh, wrong asnwer try again");
                        
                        counter++;
                        /* if (counter < 2)
                        {
                            valid = true;
                            Console.Write("Try again : ");
                        }*/
                        if (counter == 2)
                        {
                            Console.WriteLine($"The correct answer is {answer}");
                            
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

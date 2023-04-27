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
        public  void Equation()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
        public  double evaluate()
        {
            /*  dynamic operate = new operation(cards[0].Value, cards[2].Value, cards[4].Value, cards[1].Suit, cards[3].Suit);
              Console.WriteLine(operate.ToString());*/
            double answer = 0;
           if (cards[1].Suit >= cards[3].Suit)
            {
                operation operate = new operation(cards[0].Value, cards[2].Value, cards[1].Suit);
                Console.Write($"{operate.ToString()}\t" );

                double y = operate.performance();

               if (y== answer)
                {
                    operation operate2 = new operation(y, cards[4].Value, cards[3].Suit);
                    Console.Write($"{operate2.ToString()} = ?");

                    answer = operate2.performance();
                } 


            }
           else if (cards[1].Suit < cards[3].Suit)
            {
                operation operate2 = new operation(cards[0].Value, cards[2].Value, cards[1].Suit);
                Console.Write($"{operate2.ToString()}");

                double z = operate2.performance();

               if ( z!= answer)
                {
                    operation operate = new operation(z, cards[4].Value, cards[3].Suit);
                    Console.Write($"{operate.ToString()} = ?");
                    answer = operate.performance();

                }

            }
           
            return answer ;

        }
          
        public override void userInput(double question)
        {
            base.userInput(question);
        }
    }
}

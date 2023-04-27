using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{

    class fivelevels : parent
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
            dynamic operate = new operation(cards[0].Value, cards[2].Value, cards[4].Value, cards[1].Suit, cards[3].Suit);
            Console.WriteLine(operate.ToString());
            double x = operate.performance();
            return x;

        }
          
        public override void userInput(double question)
        {
            base.userInput(question);
        }
    }
}

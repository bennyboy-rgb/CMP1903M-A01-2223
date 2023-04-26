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

        public void OutputEquation()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
        public override double evaluate()
        {
            double x = 0;
            if (cards[1].Suit >= cards[3].Suit) {
                dynamic operatr1 = new operation(cards[0].Value, cards[2].Value, cards[1].Suit);
                Console.WriteLine(operatr1.ToSTring());
                x = operatr1.performance();
            }
            else if (cards[1].Suit < cards[3].Suit) 
            {
                dynamic operatr1 = new operation(cards[2].Value, cards[4].Value, cards[3].Suit);
                Console.WriteLine(operatr1.ToSTring());
                x = operatr1.performance();
            }
            return x;
        } 
    }
}

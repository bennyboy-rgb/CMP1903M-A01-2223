using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{

     class fivelevels :threeCardslevel
    {
        List<Card> cards = Pack.dealCard(5);

        public void OutputEquation()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
        /*public override double evaluate()
        {
            dynamic operate = new operation(cards[0].Value, cards[2].Value, cards[1].Suit);
        }*/
    }
}

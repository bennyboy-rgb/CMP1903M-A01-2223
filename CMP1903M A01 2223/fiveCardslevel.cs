using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    // inherits's from the parent class 
    class fiveCardslevel : LevelParents
    {
        List<Card> cards = Pack.dealCard(5);
        public void Equation()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }

        // evaluate's with respect to Bodmas by checking the suit numbers of the second and fourth cards
        // and evaluates it!!
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

                double FirstAnswer = operate.performance();
                userInput(FirstAnswer);
                while (!valid)
                {
                    valid = true;
                    operation operate2 = new operation(decimalPlaces(FirstAnswer), cards[4].Value, cards[3].Suit);
                    Console.Write(operate2.ToString());
                    answer = operate2.performance();
                }

            }
            else if (cards[1].Suit < cards[3].Suit)
            {
                operation operate2 = new operation(cards[2].Value, cards[4].Value, cards[3].Suit);
                Console.Write(operate2.ToString());

                double InitialAnswer = operate2.performance();
                userInput(InitialAnswer);
                while (!valid)
                {
                    valid = true;
                    operation operate = new operation(cards[0].Value, decimalPlaces(InitialAnswer), cards[1].Suit);
                    Console.Write(operate.ToString());
                    answer = operate.performance();

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

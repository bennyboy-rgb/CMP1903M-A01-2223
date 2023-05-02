﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class threeCardslevel :LevelParents
    {
    
        List<Card> cards = Pack.dealCard(3);

        public  void Equation()
        {         
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
        public double evaluate()
        {
            dynamic operate = new operation(cards[0].Value, cards[2].Value, cards[1].Suit);
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

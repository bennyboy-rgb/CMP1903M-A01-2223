using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        private int _value;
        private int _suit;
        public Card(int value, int suit)
        {
            _value = value;
            _suit = suit;
        }
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get { return _value; }
          
        }
 
        public int Suit
        {
            get { return _suit; }
        }



        public override string ToString()
        {
            var Values = new Dictionary<int, string>()
            {
                {1, "Ace" },
                {2, "Two" },
                {3, "Three" },
                {4, "Four" },
                {5, "Five" },
                {6, "Six" },
                {7, "Seven" },
                {8, "Eight" },
                {9, "Nine" },
                {10, "Ten" },
                {11, "Jack" },
                {12, "Queen" },
                {13, "King" }
            };

            var Suits = new Dictionary<int, string>()
            {
                {1, "Diamonds" },
                {2, "Spades" },
                {3, "Clubs" },
                {4, "Hearts" }
            };


            return Values +" : " + Suits;
        }
    }
    
}

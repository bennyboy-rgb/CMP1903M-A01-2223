using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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



        public override string ToString() // so it can return the cards itself 
        {

        
            return "Value: " + Value +" , Suit: " + Suit;
        }
    }
    
}

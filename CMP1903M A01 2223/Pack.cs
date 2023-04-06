using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
       static List<Card> pack = new List<Card>();

        public Pack()
        {
            //Initialise the card pack here
            for ( int i = 1; i<14; i ++)// 13 values 
            {
                for ( int j = 1 ; j < 5 ; j++)// 4 suits
                {
                    Card card = new Card(i,j); //ceates the cards in that sequence
                    pack.Add(card);
                  
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                return fisher_yates_method();
            }
            else if (typeOfShuffle == 2)
            {
                return riffle_shuffle_metthod();

            }
            else if (typeOfShuffle == 3)
            {
                Console.WriteLine("No shuffle");
                return true;
            }
           
            return false;

        }
        public static Card deal()
        {
           
            Card card = pack.First();
            pack.Remove(card);
            return card;

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> cardsToReturn = pack.Take(amount).ToList();
            foreach (Card card in cardsToReturn)
            {
                    pack.Remove(card);
            }

            return cardsToReturn;
        }
        public static bool fisher_yates_method() 
        {

            Random random = new Random();
            for ( int i = pack.Count; i <= 0; i--)
            {
                int j = random.Next(0,i);
                (pack[i], pack[j]) = (pack[j], pack[i]);// picks card randomly and places it ontop 
                

            }
            Console.WriteLine("Fisher_yates shuffle method !!");
            return true; 
        }
        public static bool riffle_shuffle_metthod()
        {
           
            List<Card> shuffledcards = new List<Card>();
            List<Card> half1 = pack.GetRange(0,pack.Count/2);// takes one half or the first halfof the deck
            List<Card> half2 = pack.GetRange(pack.Count / 2, pack.Count / 2); // takes the other half
            for (int i = 0; i < half1.Count; i++) {  
                shuffledcards.Add(half1[i]);// takes a card from the first half and places it on the second half 
                shuffledcards.Add(half2[i]);// takes a card from the secpmd hald and places it on the first half 


             }// places the cards on eaccother
            pack = shuffledcards;
           
            Console.WriteLine("The Riffle Shuffle Method !!");
            return true;
        }
        public static void parkprinter()// prints the deck 
        {
            foreach (Card card in pack)
            {
                card.ToString();
                Console.WriteLine(card);
            }
        }

    }
}

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
            //Deals one card
            Card card = pack.First();// picks the card from the top of the deck
            if (card == null)
            {
                Console.WriteLine("there are no more cards !!");
            }
            else
            {
                
                pack.Remove(card);
            }
            return card;

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> cardsToReturn = pack.Take(amount).ToList();
            foreach (Card card in cardsToReturn)
            {
                if (card == null)
                {
                    Console.WriteLine( "there are no more cards to pull here !!");
                }
                else
                {
                    pack.Remove(card);

                }
            }

            return cardsToReturn;
        }
        public static bool fisher_yates_method() 
        {

            Random random = new Random();
            for ( int i = pack.Count; i <= 0; i--)
            {
                int j = random.Next(0,i);
                (pack[i], pack[j]) = (pack[j], pack[i]);// picks card 
                

            }
            Console.WriteLine("Fisher_yates shuffle method !!");
            return true; 
        }
        public static bool riffle_shuffle_metthod()
        {
           
            List<Card> shuffledcards = new List<Card>();
            List<Card> half1 = pack.GetRange(0,pack.Count/2);
            List<Card> half2 = pack.GetRange(pack.Count / 2, pack.Count / 2);
            for (int i = 0; i < half1.Count; i++) {
                shuffledcards.Add(half1[i]);
                shuffledcards.Add(half2[i]);


             }
            pack = shuffledcards;
           
            Console.WriteLine("The Riffle Shuffle Method !!");
            return true;
        }
        public static void parkprinter()
        {
            foreach (Card card in pack)
            {
                card.ToString();
                Console.WriteLine(card);
            }
        }

    }
}

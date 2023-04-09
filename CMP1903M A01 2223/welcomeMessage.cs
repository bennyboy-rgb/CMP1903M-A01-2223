using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class welcomeMessage
    {
        
        public static void firstmessage()
        {
            Console.WriteLine("Hello!! \n welcome to this math tutor console application, this appllication is meant to help you with you improve you quantitative reasoning skills!!\nin this application three cards will be drawn from a deck of cards and the first card drawn will be the first value provided the second card's suit will be the operator and the third card will be the other value!!");
        }
        public static void sample()
        {
            Random random = new Random();
            Console.WriteLine("for example : ");
            int index = random.Next(1, 4);
            Pack.shuffleCardPack(index);
            List<Card> cards = Pack.dealCard(3);
            for(int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine(cards[i]);
            }
            Console.WriteLine($"the first card ({cards[0]}) takes the value as the first number which is ({cards[0].Value}) and ignore the suits number\nit then moves to the next card ({cards[1]}) and picks it's suit as the operator which is({cards[1].Suit}) ignores the value and moves to the third card and picks the value of the this card{cards[2]} which is {cards[2].Value} and asks you for an input then tells you if you get it correctly or not ");
        }
        public static void operators()
        {
            Console.WriteLine("for the operators, the suit number determines the operator to use");
            Console.WriteLine("the suit numbers and their operators!!");
            Console.WriteLine("1 = + ");
            Console.WriteLine("2 = - ");
            Console.WriteLine("3 = / ");
            Console.WriteLine("4 = x ");
        }
    }

}

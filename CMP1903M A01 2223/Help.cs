using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Help
    {

        public static String firstmessage()
        {
            return ("HELP - MENU\nHello!! \nwelcome to this math tutor console application, this appllication is meant to help you with you improve you quantitative reasoning skills!!\nin this application three cards will be drawn from a deck of cards and the first card drawn will be the first value provided the second card's suit will be the operator and the third card will be the other value!!");
        }
        public static void sample1()
        {
            Random random = new Random();
            Console.WriteLine("for the easy level : ");
            int index = random.Next(1, 4);
            Pack.shuffleCardPack(index);
            List<Card> cards = Pack.dealCard(3);
            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine(cards[i]);
            }
            Console.WriteLine($"the first card ({cards[0]}) takes the value as the first number which is ({cards[0].Value}) and ignore the suits number\nit then moves to the next card ({cards[1]}) and picks it's suit as the operator which is({cards[1].Suit}) ignores the value and moves to the third card and picks the value of the this card{cards[2]} which is {cards[2].Value} and asks you for an input then tells you if you get it correctly or not ");
        }
        public static void sample2()
        {
            Random random = new Random();
            Console.WriteLine("For the tough level :");
            int index= random.Next(1, 4);
            Pack.shuffleCardPack(index);
            List<Card> cards = Pack.dealCard(5);
            for  ( int i = 0;i < cards.Count; i++)
            {
                Console.WriteLine(cards[i]);
            }
            Console.WriteLine($"Unlike the easy level, this level is divided into two parts based on the bodmas rules!!");
            Console.WriteLine($"Here, 5 cards are drawn, the first card drawn here is ({cards[0]}), the value which is ({cards[0].Value}] is taken as the first number and the suit is ignored");
            Console.WriteLine($"To get the first operator we pick the suit number which is ({cards[1].Suit}) which can be seen at the top of the page");
            Console.WriteLine($"The next number which is ({cards[2].Value}) and so on" );
            Console.WriteLine($"You have to get the first part so you can get the other part");
            Console.WriteLine($"If you get the answer wrong twice, the application returns your answer as well... and moves tp the next question!!");
            Console.WriteLine($"Enjoy the application !!");

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
        public static void back()
        {
            bool valid = false;
            int userInput = 0;
            while (!valid)
            {
                Console.WriteLine("Main Menu or quit");
                Console.WriteLine("Enter :");
                Console.WriteLine("(1) To return to main menu");
                Console.WriteLine("(2) To quit Application");
                if(int.TryParse(Console.ReadLine(), out userInput))
                {
                    if(userInput == 1)
                    {
                        valid = true;
                        dynamic tutorial = new MainMenu();
                        tutorial.menu();
                    }
                    else if ( userInput == 2)
                    {
                        valid = true;
                        Messages message = new Messages();
                        Console.WriteLine(message.goodByeMessage()); 
                    }
                }
                else 
                {
                    Console.WriteLine("Input an integer please");
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class testing
    {
        public testing() 
        {
            Pack pack = new Pack();
            Console.WriteLine( " How many cards do you want to deal : ");
          
            try
            {
                int card_dealing = int.Parse(Console.ReadLine());
                if (card_dealing > 52)
                {
                    Console.WriteLine(" You can't deal more then 52 cards !!");
                }
                else
                {
                    Console.WriteLine(Pack.dealCard(card_dealing));
                }
            }
            catch (System.FormatException) {
                Console.WriteLine( " You can only input integers !!");
              


            }

            Console.WriteLine(" what shuffle do you want : ");
            int user_input = int.Parse(Console.ReadLine());
           // Console.WriteLine(Pack.shuffleCardPack(user_input));
            try
            {
                if (user_input >=4|| user_input == null)
                {
                    Console.WriteLine( "wrong input !!");
                }
                else
                {
                    Console.WriteLine(Pack.shuffleCardPack(user_input));
                }

            }
            catch (System.FormatException) 
            {
                Console.WriteLine(" You need to input an integer !!!");
            }
           
            Pack.parkprinter();



            Console.ReadLine();
        }
    }
}

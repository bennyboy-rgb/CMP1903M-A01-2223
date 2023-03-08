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

            
            Console.WriteLine(Pack.shuffleCardPack(1));
            Console.WriteLine( Pack.riffle_shuffle_metthod());
           
            Console.WriteLine(Pack.shuffleCardPack(2));
            Console.WriteLine(Pack.shuffleCardPack(3));
         
            Console.WriteLine(Pack.deal());
            //Console.WriteLine(Pack.deal());
            //Console.WriteLine(" how many cards do you want : ");
            //int benny = int.Parse(Console.ReadLine());
            //Console.WriteLine(Pack.dealCard(benny)[0]);
            //Console.WriteLine();
            //Pack.parkprinter();


            Console.ReadLine();
        }
    }
}

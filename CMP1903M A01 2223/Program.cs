using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();


            Pack.shuffleCardPack(2);

            Console.WriteLine(Pack.deal());
            Console.WriteLine(" how many cards do you want : ");
            int benny = int.Parse(Console.ReadLine());
            Console.WriteLine(Pack.dealCard(benny)[0]);
            Console.WriteLine();
            Pack.parkprinter();

            
            Console.ReadLine();
        }
    }
}

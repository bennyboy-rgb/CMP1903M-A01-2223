using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class parent
    {
        public virtual void userInput(float question)
        {

            bool valid = false;
            int counter = 0;
            float input = 0;
            while (!valid)
            {
                float answer = question;
                if (float.TryParse(Console.ReadLine(), out input))
                {

                    if (input == answer)
                    {
                        valid = true;
                        Console.WriteLine("Yayy, correct answer!!");
                    }
                    else
                    {
                        Console.WriteLine("\nArghhh, wrong answer!!");

                        counter++;
                        if (counter < 2)
                        {
                            Console.Write("Try again : ");
                        }
                        else if (counter == 2)
                        {
                            valid = true;
                            Console.WriteLine($"The correct answer is {decimalPlaces(answer)}\n");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Input an integer please!!");
                }
            }


        }


        // returns answer to 2 decimal places
        private double decimalPlaces(double num)
        {
            return Math.Truncate(num * 100) / 100;
        }

    }
}

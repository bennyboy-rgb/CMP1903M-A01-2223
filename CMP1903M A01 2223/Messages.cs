using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    interface Imessages
    {
       
        string goodByeMessage();
        string welcomemessage();
    }
     class Messages : Imessages
    {
        public string welcomemessage()
        {
            return "Hello, welcome to the math tutor application !!";
        }
        public string goodByeMessage()
        {
            return "Thank you for your time !! \nPress enter key to exit ...";
          /*  Console.WriteLine("Thank you for your time !!");
            Console.WriteLine("Press enter key to exit ...");*/
        }
    }

}

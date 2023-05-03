using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{

    class Messages : Imessages
    {
        public virtual string welcomemessage()
        {
            return "Hello, welcome to the math tutor application !!";
        }
        public virtual string goodByeMessage()
        {
            return "Thank you for your time !! \nPress enter key to exit ...";
        }
        public virtual string CardDrawnMessages()
        {
            return "These are your cards drawn from the deck!! \n";
        }
    }

}

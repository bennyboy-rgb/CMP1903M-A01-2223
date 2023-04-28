using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class fiveCardoperation : operation
    {
        public float _num3;
        public float _operand2;
        public fiveCardoperation(float num1, float num2, float num3, float operand, float operand2) : base(num1, num2, operand)
        {
            _num3 = num3;
            _operand2 = operand2;

        }
        
        public override string ToString()
        {

            char operatorTocharacter(float op)
            {
                char operatorCharacter = '0';
                if (op == 1) operatorCharacter = '+';
                else if (op == 2) { operatorCharacter = '-'; }
                else if (op == 3) { operatorCharacter = '/'; }
                else if (op == 4) { operatorCharacter = 'X'; }
                return operatorCharacter;
            }
            char operator1Character = operatorTocharacter(_operand);
            char operator2Character = operatorTocharacter(_operand2);


            return $"{_num1} {operator1Character} {_num2} {operator2Character} {_num3} =? ";

        }
    }
        
    
}

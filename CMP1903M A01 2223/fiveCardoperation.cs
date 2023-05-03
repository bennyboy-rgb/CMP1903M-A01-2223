using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    // inherit's from the three-card-class and displays 5 cards
    internal class fiveCardoperation : operation
    {
        
        public double _num3;
        public int _operand2;
        public fiveCardoperation(double num1, double num2, double num3, int operand, int operand2) : base(num1, num2, operand)
        {
            _num3 = num3;
            _operand2 = operand2;

        }
        
        // displays the equation for the question of 5 cards!!
        public override string ToString()
        {
            // returns the operator
            char operatorTocharacter(int op)
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


            return $"{_num1} {operator1Character} {_num2} {operator2Character} {_num3} = ? ";

        }
    }
        
    
}

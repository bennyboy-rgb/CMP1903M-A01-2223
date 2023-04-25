using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
     class operation
    {
          public double _num1;
         public double _num2;
         public int _operand;
        
        public operation(double num1, double num2, int operand)
        {
           _num1 = num1;
            _num2 = num2;
            _operand = operand;

        }

        public double performance()
        {
          if (_operand == 1)
            {
                return _num1 + _num2;
            }
          else if (_operand == 2)
            {
                return _num1 - _num2;
            }
          else if (_operand == 3)
            {
                return _num1 * _num2;
            }
          else if(_operand == 4)
            {
                return _num1 * _num2;
            }
            return 0;
        }
    }
}

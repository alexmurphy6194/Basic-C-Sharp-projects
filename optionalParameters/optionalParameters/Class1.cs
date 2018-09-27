using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParameters
{
    public class doMath
    {
        public int optionalNum(int num1, int multiplier = 1){
            num1 = (num1 + 13)*multiplier;
        return num1;
        }
    }
}

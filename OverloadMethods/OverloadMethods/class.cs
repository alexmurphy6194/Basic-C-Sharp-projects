using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethods
{
    public class Operations
    {
        public int sameMethod(int num1)
        {
            num1++;
            return num1;
        }
        public decimal sameMethod(decimal num1)
        {
            num1 = num1 / 2;
            return num1;
        }
        public int sameMethod(string words)
        {
            int num = Convert.ToInt32(words);
            num = num * 3; 
            return num;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Exercise
{
    public static class arithmetic
    {
        public static string isEven(int input)
        {

            string result = "";
            result = input % 2 == 0 ? "Even" : "Odd";
            return result;
        }

        public static int squared(int input1)
        {

            int output = input1 * input1;
            return output;
        }

        public static int plusOne(int input2)
        {

            int output1 = input2+1;
            return output1;
        }
    }
}
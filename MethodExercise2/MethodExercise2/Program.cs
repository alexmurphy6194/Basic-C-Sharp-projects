using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            practiceClass sample = new practiceClass();

            practiceClass.mathOperation(10, 50);
            practiceClass.mathOperation(num1: 13, num2: 11);
            Console.Read();
        }
    }
}

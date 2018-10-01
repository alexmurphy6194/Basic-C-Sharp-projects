using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(String[] args)
        {
            //Employee<int> Employee1 = new Employee<int>() { FirstName = "Sample", LastName = "Student" , Id = 1};
            //Employee<int> Employee2 = new Employee<int>() { FirstName = "Alex", LastName="Murphy",Id = 2 };
            //bool same = Employee1 == Employee2;
            //Employee1.SayName();
            //Console.WriteLine("And");
            //Employee2.SayName();
            //Console.WriteLine("Are the same employee?.....Looking at their ID's, this is " + same);
            
            Employee<String> Employee3 = new Employee<String>() { FirstName = "alex", LastName = "murphy" };
            Employee3.Things = new List<string>();
            Employee3.Things.Add("word1");
            Employee3.Things.Add("Word2");
            Employee3.Things.Add("Word3");

            Employee<int> Employee4 = new Employee<int>();
            Employee4.Things = new List<int>();
            Employee4.Things.Add(1);
            Employee4.Things.Add(2);
            Employee4.Things.Add(3);

            foreach (String thing in Employee3.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in Employee4.Things)
            {
                Console.WriteLine(thing);
            }
            Console.Read();
        }
    }
}
